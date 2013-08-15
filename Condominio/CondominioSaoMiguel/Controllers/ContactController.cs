using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using CondominioSaoMiguel.Models;

using Util;

namespace CondominioSaoMiguel.Controllers
{
    public class ContactController : BaseController
    {
        public ActionResult GetPartialIndexView(ContactModel model)
        {
            return PartialView("Index", model);
        }

        public ActionResult SendEmail(ContactModel contact)
        {
            if (ValidateModel())
            {
                try{
                    Util.Util.SendEmail(contact.Email, contact.Name, contact.DDD ?? 000, contact.Phone ?? 00000000, contact.Message);
                    //Util.Util.SendEmailCopyToUser(contact.Email, contact.Name, contact.DDD ?? 000, contact.Phone ?? 00000000, contact.Message);
                }
                catch(Exception error)
                {
                    ModelState.AddModelError(string.Empty, "Ocorreu um erro ao enviar o e-mail. Por favor, entre em contato por telefone.");
                    SetError();
                    return GetJSON(contact, "Index", false);
                }
                return GetJSON(contact, "Index", true);
            }
            return GetJSON(contact, "Index", false);
        }

        private bool ValidateModel()
        {
            ViewBag.ModelValid = ModelState.IsValid;
            if (!ModelState.IsValid)
                SetError();
            return ModelState.IsValid;
        }

        private void SetError()
        {
            ViewBag.Error = true;
            ViewBag.Success = false;
        }

    }
}
