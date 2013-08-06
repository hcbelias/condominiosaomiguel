using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Util.Attributes;

namespace WebControllers
{
    public class ErrorController : Controller
    {

        public ActionResult Index(string p_HTMLExceptionMessage)
        {
            Response.StatusCode = 404;
            return View("Error");
        }

        [HttpGet]
        public ActionResult Http404(string p_HTMLExceptionMessage)
        {
            Response.StatusCode = 404;
            return View("Error");
        }

        [HttpGet]
        public ActionResult Http500(string p_HTMLExceptionMessage)
        {
            Response.StatusCode = 500;
            return View("Error");
        }
    }
}
