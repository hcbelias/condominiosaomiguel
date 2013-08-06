using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

using System.Web.Routing;
using System.Web.Security;

namespace Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

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
            if (code != 404)
            {
                Util.Util.SendEmail("Erro - Clinica Salute", v_HTMLErrorMessage);
            }

            //Response.Clear();
            //Server.ClearError();
            //Context.Server.TransferRequest("/Error/Index", true);
        }

    }

}