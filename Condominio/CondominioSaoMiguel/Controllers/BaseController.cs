using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using CondominioSaoMiguel.Models;
using CondominioSaoMiguel.Util;

namespace CondominioSaoMiguel.Controllers
{
    [Compress]
    [OutputCache(Duration = 3600)]
    public abstract class BaseController : Controller
    {
        
        public ActionResult Index()
        {
            return 
                GetIndexView(new BaseModel());
        }

        
        public ActionResult IndexPartialView()
        {
            return GetPartialIndexView(new BaseModel());
        }

        public virtual ActionResult GetPartialIndexView(BaseModel model)
        {
            return PartialView("Index");
        }

        public virtual ActionResult GetIndexView(BaseModel model)
        {
            return View("Index");
        }

        protected ActionResult GetJSON(object model, string view, bool success)
        {
            return Json(new { Success = success, Data = RenderRazorViewToString(view, model) }, JsonRequestBehavior.AllowGet);
        }

        #region Rendering
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
        #endregion

        
    }

    public class CompressAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            var encodingsAccepted = filterContext.HttpContext.Request.Headers["Accept-Encoding"];
            if (string.IsNullOrEmpty(encodingsAccepted)) return;

            encodingsAccepted = encodingsAccepted.ToLowerInvariant();
            var response = filterContext.HttpContext.Response;
            if (encodingsAccepted.Contains("gzip"))
            {
                response.AppendHeader("Content-encoding", "gzip");
                response.Filter = new GZipStream(response.Filter, CompressionMode.Compress);
            }else
            if (encodingsAccepted.Contains("deflate"))
            {
                response.AppendHeader("Content-encoding", "deflate");
                response.Filter = new DeflateStream(response.Filter, CompressionMode.Compress);
            }
            
        }
    }
}
