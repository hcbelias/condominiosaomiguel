using System;
using System.Web.Mvc;
using Model;
using System.Web.Security;
using Web.UtilWeb;
using System.Collections.Generic;

namespace WebControllers
{
    public partial class LoginController
    {
        #region Implementation of IBaseController

        new public ActionResult OnCreate(BaseModel p_Model)
        {
            DataController.MasterDataController v_DataController =
            DataController.Controllers.GetMasterData();
            v_DataController.CreateLogin((LoginModel)p_Model);
            return Index();
        }

        new public ActionResult OnDelete(int p_Identifier)
        {
            DataController.MasterDataController v_DataController =
            DataController.Controllers.GetMasterData();
            v_DataController.DeleteLogin(p_Identifier);
            return Index();
        }

        new public ActionResult OnEdit(BaseModel p_Model)
        {
            DataController.MasterDataController v_DataController =
            DataController.Controllers.GetMasterData();
            v_DataController.EditLogin((LoginModel)p_Model);
            return Index();
        }

        //public ActionResult OnException(Exception p_Exception)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion
        [OutputCache(Duration = 3600)]
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(Logon p_Model, String p_ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                // Authenticate the user.
                if (UserManager.ValidateUser(p_Model, Response))
                {

                    if (string.IsNullOrWhiteSpace(p_ReturnUrl))
                    {
                        return Redirect(
                            FormsAuthentication.GetRedirectUrl(p_Model.Email, true));
                    }
                    else
                    {
                        return Redirect(p_ReturnUrl);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "E-mail e/ou senha inválido(s)");
                }
            }
            return View("Login", p_Model);
        }

        public void Logout()
        {
            if (UserManager.User != null && UserManager.User.Email != null && HttpContext.Session["Menu_" + UserManager.User.Email] != null)
            {
                this.HttpContext.Session.Remove("Menu_" + UserManager.User.Email);
            }
            UserManager.Logoff(Session, Response);
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }

        public ActionResult DadosPessoais()
        {
            //UserManager.Logoff(Session, Response);
            return View("Login");
        }
    }
}