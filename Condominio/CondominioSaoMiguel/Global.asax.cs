using System;

using System.Web.Mvc;
using System.Web.Routing;
using System.Web;

namespace CondominioSaoMiguel
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        void Application_Error(object sender, EventArgs e)
        {
            var error = Server.GetLastError();
            var code = (error is HttpException) ? (error as HttpException).GetHttpCode() : 500;

            var v_HTMLErrorMessage =
                "<strong>Message: </strong><br/>" + error.Message + "<br/><br/><strong>StackTrace: </strong><br/>" +
                    error.StackTrace + "<br/><br/><strong>InnerException: </strong><br/>" + error.InnerException + "<br/><br/><strong>Servidor:</strong><br/>" + this.Server.MachineName;
            if (code != 404)
            {
                
                Util.Util.SendErrorEmail("Erro - Condomínio São Miguel", v_HTMLErrorMessage);
            }

            //Response.Clear();
            //Server.ClearError();
            //Context.Server.TransferRequest("/Error/Index", true);
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}