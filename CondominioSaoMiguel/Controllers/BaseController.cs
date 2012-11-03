using System;
using System.Collections.Generic;
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

        public virtual ActionResult GetPartialIndexView(BaseModel model)
        {
            return PartialView("Index");
        }

        public virtual ActionResult GetIndexView(BaseModel model)
        {
            return View("Index");
        }
    }
}
