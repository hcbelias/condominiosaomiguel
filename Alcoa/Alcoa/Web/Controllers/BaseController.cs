using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.IO;
using System.Web;
using Model;
using Util;
using Util.Attributes;
using Model;
using Web.UtilWeb;

namespace WebControllers
{

    public abstract class BaseController : Controller, IBaseController
    {
        public abstract ActionResult Index();

        public abstract ActionResult Create();

        public abstract ActionResult Edit(int? p_Identifier);

        public abstract ActionResult Info(int? p_Identifier);

        public abstract ActionResult Delete(int p_Identifier);

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

        protected ActionResult GetJSON(IDictionary<string, string> nameValueCollection)
        {
            return Json(new JavaScriptSerializer().Serialize(nameValueCollection));
        }



        new public virtual ActionResult OnCreate(BaseModel p_Model)
        {
            throw new NotImplementedException();
        }

        public virtual ActionResult OnDelete(int p_Identifier)
        {
            throw new NotImplementedException();
        }

        public virtual ActionResult OnEdit(BaseModel p_Model)
        {
            throw new NotImplementedException();
        }

        public ActionResult OnException(Exception p_Exception)
        {
            return View("Error", p_Exception);
        }


        public virtual BaseModel GetModel(Int32 p_Identifier)
        {
            throw new NotImplementedException();
        }

        public virtual BaseModel GetModelInfo(Int32 p_Identifier)
        {
            throw new NotImplementedException();
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

        public string CreatedMessage(string p_EntityName)
        {
            return string.Format("{0} criado com sucesso.", p_EntityName);
        }

        public string EditedMessage(string p_EntityName)
        {
            return string.Format("{0} editado com sucesso.", p_EntityName);
        }

        public string DeletedMessage(string p_EntityName)
        {
            return string.Format("{0} removido com sucesso.", p_EntityName);
        }

        protected ActionResult Home(String p_Message)
        {
            return View("Home",
                        new HomeModel()
                        {
                            Message = p_Message,
                            ClassCSS = Constants.Page.SUCCESS_MESSAGE_CLASS
                        });
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

        public static Util.Enum.Perfil GetPerfilEnum(string p_Email)
        {
            Util.Enum.Perfil v_Perfil;

            bool v_Success = Util.Enum.Perfil.TryParse(
                DataController.Controllers.GetMasterData().GetLoginPeloEmail(p_Email).Perfil.Nome, out v_Perfil);
            return v_Success ? v_Perfil : Util.Enum.Perfil.Desconhecido;
        }

        

    }
}
