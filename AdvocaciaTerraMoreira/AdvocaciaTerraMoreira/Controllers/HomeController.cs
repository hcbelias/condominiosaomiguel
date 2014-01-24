using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Util.Attributes;


namespace Web.Controllers
{
    [AllowAnonymous]
    public class HomeController : BaseController
    {
        
        public ActionResult Home()
        {
            return View("Home");
        }

        public PartialViewResult Index()
        {
            return PartialView();
        }

        public PartialViewResult ApoioCliente()
        {
            return PartialView();
        }

        public PartialViewResult Atuacao()
        {
            return PartialView();
        }

        public PartialViewResult Contato()
        {
            return PartialView();
        }

        public PartialViewResult Escritorio()
        {
            return PartialView();
        }

        public PartialViewResult Glossario()
        {
            return PartialView();
        }

        public PartialViewResult INSS()
        {
            return PartialView();
        }

    }
}
