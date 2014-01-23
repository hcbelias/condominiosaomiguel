using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Util;
using Web.Models;

namespace Web.Controllers
{
    public class EmailController : BaseController
    {
        public string BuildContactEmailBody(string email, string name, string phone, string mensagem)
        {
            return RenderRazorViewToString("ContactEmail", new Contact(){Email=email, Name=name, Phone=phone, Message=mensagem});
        }

        public ActionResult ContactEmail()
        {
            return View(new Contact() { Message = "Teste", Phone = "989898010982", Email = "23123@sdasd.com", Name = "name" });
        }

        public ActionResult SendEmail(Contact contact)
        {
            if (ValidateModel())
            {
                string returnString = BuildContactEmailBody(contact.Email, contact.Name, contact.Name, contact.Message);
                try
                {
                    Util.Email.SendEmail(Constants.MSG_CONTACT_EMAIL_SUBJECT, returnString, new string[] { contact.Email });
                    //Util.Email.SendContactEmail(contact.Email, contact.Name, contact.Phone, contact.Message);
                    //Util.Util.SendEmailCopyToUser(contact.Email, contact.Name, contact.DDD ?? 000, contact.Phone ?? 00000000, contact.Message);
                }
                catch (Exception error)
                {
                    ModelState.AddModelError(string.Empty, "Ocorreu um erro ao enviar o e-mail. Por favor, entre em contato por telefone.\n"+error.Message);
                    SetError();
                    return GetJSON(returnString, false);
                }
                return GetJSON(returnString, true);
            }
            return GetJSON("", false);
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
