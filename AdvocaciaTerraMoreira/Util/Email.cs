using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Util.Configuration;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net.Mime;
using System.IO;
using System.Web.Mvc;

namespace Util
{
    public class Email
    {


        public static void SendErrorEmail(string p_Body)
        {
            SendEmail("Erro - Advocacia Moreira Terra", p_Body, new string[] { ConfigurationReader.GetEmailManager(), ConfigurationReader.GetEmailManager() });
        }

        public static void SendEmail(string p_Subject, string p_Body, string p_To)
        {
            SendEmail(p_Subject, p_Body, new string[] { p_To });
        }

        public static void SendEmail(string p_Subject, string p_Body, string[] p_To)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(p_Subject) || p_To.Count() == 0) return;
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                SmtpClient smtp = new SmtpClient();


                foreach (var i_To in p_To)
                {
                    mail.To.Add(new MailAddress(i_To));
                }
                mail.Subject = String.Format("{0} - {1}", Internationalization.EnterpriseName, p_Subject);
                mail.IsBodyHtml = true;
                LinkedResource resourceHeader = new LinkedResource(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                    "images/TM.jpg"), new ContentType(System.Net.Mime.MediaTypeNames.Image.Jpeg));
                resourceHeader.ContentId = "header";
                mail.Body = p_Body;       

                smtp.Send(mail);
            }
            catch
            {
                return;
            }
        }

    }

}
