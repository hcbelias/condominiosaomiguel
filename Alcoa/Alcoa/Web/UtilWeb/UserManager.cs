using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Security.Principal;
using System.Web.Security;
using System.Web.Script.Serialization;

namespace Web.UtilWeb
{
    public class User
    {
        public int Id { get; set; }
        public int PerfilId { get; set; }
        public string Perfil { get; set; }
        public string Email { get; set; }

    }

    public class MyPrincipal : IPrincipal
    {
        public MyPrincipal(IIdentity p_Identity)
        {
            this.Identity = p_Identity;

            this.User = new User()
                {
                    Email = p_Identity.Name,

                };
        }

        public IIdentity Identity
        {
            get;
            private set;
        }

        public bool IsInRole(string role)
        {
            return true;
        }

        public User User { get; set; }
    }

    public static class UserManager
    {
        public static User User
        {
            get
            {
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    // The user is authenticated. Return the user from the forms auth ticket.
                    MyPrincipal v_Principal = new MyPrincipal(HttpContext.Current.User.Identity);
                    return v_Principal.User;
                }
                else if (HttpContext.Current.Items.Contains("User"))
                {
                    // The user is not authenticated, but has successfully logged in.
                    return ((User)HttpContext.Current.Items["User"]);
                }
                else
                {
                    return null;
                }
            }
        }

        public static User GetUser(string p_Email, string p_Password)
        {
            User v_User = null;
            DataController.MasterDataController v_Controller = DataController.Controllers.GetMasterData();
            Model.LoginModel v_Login = v_Controller.GetLogin(p_Email, p_Password);
            if (v_Login != null)
            {
                v_User = new User
                {
                    Id = v_Login.Id,
                    Email = v_Login.Email,
                    PerfilId = v_Login.Perfil.Id,
                    Perfil = v_Login.Perfil.Name
                };
            }
            return v_User;
        }

        public static bool ValidateUser(Logon p_Logon, HttpResponseBase p_Response)
        {
            bool v_Result = false;
            User v_User = GetUser(p_Logon.Email, p_Logon.Password);
            if (v_User != null)
            {
                HttpContext.Current.Items.Add("User", v_User);
                var v_Serializer = new JavaScriptSerializer();
                string v_UserData = v_Serializer.Serialize(UserManager.User);
                FormsAuthenticationTicket v_Ticket = new FormsAuthenticationTicket(1,
                        p_Logon.Email,
                        DateTime.Now,
                        DateTime.Now.AddMinutes(5),
                        true,
                        v_UserData,
                        FormsAuthentication.FormsCookiePath);
                // Encrypt the ticket.
                string v_EncryptTicket = FormsAuthentication.Encrypt(v_Ticket);

                p_Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, v_EncryptTicket));
                v_Result = true;
            }

            return v_Result;
        }

        public static void Logoff(HttpSessionStateBase p_Session, HttpResponseBase p_Response)
        {
            p_Session.Clear();
            p_Session.Abandon();
            HttpContext.Current.Items.Remove("User");
            p_Response.Cookies.Remove(FormsAuthentication.FormsCookieName);
            HttpContext.Current.Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            FormsAuthentication.SignOut();
        }
    }

    public class Logon
    {

        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(Util.Internationalization))]
        [Display(Name = "Email", ResourceType = typeof(Util.Internationalization), Prompt = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(Util.Internationalization))]
        [Display(Name = "Password", ResourceType = typeof(Util.Internationalization), Prompt = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

}