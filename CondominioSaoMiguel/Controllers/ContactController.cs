﻿using System;
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
                    SendEmail(contact.Email, contact.Name, contact.DDD ?? 000, contact.Phone??00000000, contact.Message);

                }
                catch(Exception error)
                {
                    SetError();
                    return GetPartialIndexView(contact);
                }
                return GetPartialIndexView(new ContactModel());
            }
            return GetPartialIndexView(contact);
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
        }

        
        private void SendEmail(string email, string name, int ddd, int phone, string mensagem)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient(ConfigurationReader.GetEmailServerAddress());
            mail.To.Add(new MailAddress(ConfigurationReader.GetEmailManager()));
            mail.To.Add(new MailAddress(ConfigurationReader.GetEmailAdmin()));
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
