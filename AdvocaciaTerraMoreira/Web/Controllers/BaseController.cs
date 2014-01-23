using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.IO;
using System.Web;
using Util;
using Util.Attributes;
using Util.Configuration;

namespace Web.Controllers
{
    public abstract class BaseController : System.Web.Mvc.Controller
    {
        public string RenderRazorViewToString(string viewName)
        {
            return RenderRazorViewToString(viewName, null);
        }

        public string RenderRazorViewToString(string viewName, object model)
        {
            ViewData.Model = model;
            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                var viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(ControllerContext, viewResult.View);
                return sw.GetStringBuilder().ToString();
            }
            
        }

        protected ActionResult GetJSON(object model, string view, bool success)
        {
            return Json(new { Success = success, Data = RenderRazorViewToString(view, model) });
        }

        protected ActionResult GetJSON(string Data, bool success)
        {
            return Json(new { Success = success, Data = Data });
        }

        protected ActionResult GetJSON(IDictionary<string, string> nameValueCollection)
        {
            return Json(new JavaScriptSerializer().Serialize(nameValueCollection));
        }

        

        public string ToHtml(string viewToRender, ViewDataDictionary viewData, ControllerContext controllerContext)
        {
            var result = ViewEngines.Engines.FindView(controllerContext, viewToRender, null);

            var output = new StringWriter();
            var viewContext = new ViewContext(controllerContext, result.View, viewData, controllerContext.Controller.TempData, output);
            result.View.Render(viewContext, output);
            result.ViewEngine.ReleaseView(controllerContext, result.View);

            return output.ToString();
        }

        public void SetErrorMessage(string p_Message)
        {
            ViewBag.Message = p_Message;
            ViewBag.MessageError = true;
            ViewBag.MessageSuccess = false;
        }

        public void SetInfoMessage(string p_Message)
        {
            ViewBag.Message = p_Message;
            ViewBag.MessageError = false;
            ViewBag.MessageSuccess = false;
        }

        public void SetSuccessMessage(string p_Message)
        {
            ViewBag.Message = p_Message;
            ViewBag.MessageSuccess = true;
            ViewBag.MessageError = false;
        }

        protected bool IsContentTypeSuportted(HttpPostedFileBase p_Arquivo)
        {
            switch (p_Arquivo.ContentType)
            {
                case "image/jpeg":
                case "image/bmp":
                    return true;
                default:
                    return false;
            }
        }

        protected bool IsContentLengthSuportted(HttpPostedFileBase p_Arquivo)
        {
            return (p_Arquivo.ContentLength < ConfigurationReader.GetMaxContentLength());
        }

        protected string GetServerFullPath(string p_RelativePath)
        {
            return Server.MapPath("~/" + p_RelativePath);
        }

    }
}
