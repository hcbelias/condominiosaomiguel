using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Util.Attributes;
using Model;

namespace WebControllers
{
    [Compress]
    [LogonAuthorize]
    public class HomeController : Controller
    {

        public ActionResult Index(HomeModel p_Model)
        {
            return View("Home", p_Model);
        }
    }
}
