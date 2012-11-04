using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using CondominioSaoMiguel.Models;
using CondominioSaoMiguel.Util;

namespace CondominioSaoMiguel.Controllers
{
    public abstract class BaseController : Controller
    {
        public ActionResult Index()
        {
            return GetIndexView(new BaseModel());
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
            return Json(new { Success = success, Data = RenderRazorViewToString(view, model) });
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
}
