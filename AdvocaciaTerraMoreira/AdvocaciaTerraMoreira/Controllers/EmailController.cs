using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Util;
using AdvocaciaTerraMoreira.Models;

namespace Web.Controllers
{
    [OutputCache(CacheProfile = "NoCache")]
    public class EmailController : BaseController
    {
        public string BuildContactEmailBody(string email, string name, string phone, string mensagem, string view)
        {
            return RenderRazorViewToString("ContactEmailPartial", new ContactModel() { Email = email, Name = name, Phone = phone, Message = mensagem });
        }

        public ActionResult ContactEmail()
        {
            return View(new AdvocaciaTerraMoreira.Models.ContactModel() { Message = "Teste", Phone = "989898010982", Email = "23123@sdasd.com", Name = "name" });
        }

        public ActionResult SendEmail(string Email, string Name, string Phone, string Message)
        {
            if (ValidateModel())
            {
                string returnString = BuildContactEmailBody(Email, Name, Name, Message, "ContactEmailPartial");
                try
                {
                    string emailBody = BuildContactEmailBody(Email, Name, Name, Message, "ContactEmail");
                    Util.Email.SendEmail(Constants.MSG_CONTACT_EMAIL_SUBJECT, emailBody, new string[] { Util.Configuration.ConfigurationReader.GetEmailManager() });
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
