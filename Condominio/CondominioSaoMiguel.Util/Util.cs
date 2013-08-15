using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net.Mail;

namespace Util
{
    public class Util
    {
        public static String ToBase64(String p_FilePath)
        {
            Stream p_Stream = new FileStream(p_FilePath, FileMode.Open, FileAccess.Read);
            return ToBase64(p_Stream);
        }

        public static String ToBase64(Stream stream)
        {

            // Define base 64 string
            Byte[] bytes = new Byte[stream.Length];
            Int64 data = stream.Read(bytes, 0, (Int32)stream.Length);
            stream.Close();
            return Convert.ToBase64String(bytes, 0, bytes.Length);

        } // ToBase64

        public static Stream FromBase64(String base64)
        {

            // Define HttpPostedFileBase file
            Byte[] bytes = Convert.FromBase64String(base64);
            Stream stream = new MemoryStream(bytes);
            stream.Close();
            return stream;

        } // FromBase64

        public static void SendEmail(string email, string name, int ddd, int phone, string mensagem)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient(ConfigurationReader.GetEmailServerAddress());
            mail.To.Add(new MailAddress(ConfigurationReader.GetEmailManager()));
            mail.To.Add(new MailAddress(ConfigurationReader.GetEmailAdmin()));
            mail.From = new MailAddress(ConfigurationReader.GetEmailDefault());
            mail.Subject = Constants.Messages.MSG_EMAIL_SUBJECT;
            mail.Body = BuildEmailBody(email, name, ddd, phone, mensagem);
            smtp.Send(mail);
        }

        private static string BuildEmailBody(string email, string name, int ddd, int phone, string mensagem)
        {
            StringBuilder messageBody = new StringBuilder();
            messageBody.AppendLine("Nome: " + name);
            messageBody.AppendLine("Email: " + email);
            messageBody.AppendLine("Telefone: (" + ddd + ") " + phone);
            messageBody.AppendLine("Mensagem: ");
            messageBody.AppendLine(mensagem);
            return messageBody.ToString();
        }

        public static void SendErrorEmail(string p_Title, string v_HTMLErrorMessage)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient(ConfigurationReader.GetEmailServerAddress());
            mail.To.Add(new MailAddress(ConfigurationReader.GetEmailManager()));
            mail.To.Add(new MailAddress(ConfigurationReader.GetEmailAdmin()));
            mail.From = new MailAddress(ConfigurationReader.GetEmailDefault());
            mail.Subject = p_Title;
            mail.Body = v_HTMLErrorMessage;
            smtp.Send(mail);
        }
    }
}
