using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        void Application_Error(object sender, EventArgs e)
        {
            var error = Server.GetLastError();
            var code = (error is HttpException) ? (error as HttpException).GetHttpCode() : 500;

            var v_HTMLErrorMessage =
                "<strong>Message: </strong><br/>" + error.Message + "<br/><br/><strong>StackTrace: </strong><br/>" +
                    error.StackTrace + "<br/><br/><strong>InnerException: </strong><br/>" + error.InnerException + "<br/><br/><strong>Servidor:</strong><br/>" + this.Server.MachineName;
            Util.Email.SendErrorEmail(v_HTMLErrorMessage);
            Response.Clear();
            Server.ClearError();
            //Context.Server.TransferRequest("/Error/Index", true);
        }
       
    }
}