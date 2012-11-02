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
    public class ContatoEmailController : Controller
    {
        public ActionResult Index()
        {
            return GetPartialView(new ContatoEmailModel());
        }

        public ActionResult SendEmail(ContatoEmailModel contato)
        {
            if (ModelState.IsValid)
            {
                try{
                    SendEmail(contato.Email, contato.Name, contato.DDD, contato.Phone, contato.Message);
                }
                catch(Exception error)
                {
                    ModelState.AddModelError(string.Empty, "Ocorreu um erro ao enviar e-mail.");
                }
            }
            return GetPartialView(contato);
        }

        public ActionResult GetPartialView(ContatoEmailModel contato)
        {
            return PartialView("Contato", contato);
        }

        private void SendEmail(string email, string name, int ddd, int phone, string mensagem)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient(ConfigurationReader.GetEmailServerAddress());
            mail.To.Add(new MailAddress(ConfigurationReader.GetEmailManager()));
            mail.From = new MailAddress(ConfigurationReader.GetEmailDefault());
            mail.Subject = Constants.Messages.MSG_EMAIL_SUBJECT;
            mail.Body = BuildEmailBody(email,name,ddd,phone,mensagem);            
            smtp.Send(mail);
        }

        private string BuildEmailBody(string email, string name, int ddd, int phone, string mensagem)
        {
            StringBuilder messageBody = new StringBuilder();
            messageBody.AppendLine("Nome: " + name);
            messageBody.AppendLine("Email: " + email);            
            messageBody.AppendLine("Telefone: (" + ddd + ") "+ phone);
            messageBody.AppendLine("Mensagem: ");
            messageBody.AppendLine(mensagem);
            return messageBody.ToString();
        }
    }
}
