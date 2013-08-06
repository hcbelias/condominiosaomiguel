using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Xsl;
using System.Collections;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Net.Mail;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Web.Mvc;


namespace Util
{
    public class Util
    {
        public static MethodInfo getMethodInfo(IMessage message)
        {
            IDictionary myDictionary = message.Properties;
            Type classType = Type.GetType((String)myDictionary["__TypeName"]);
            MethodInfo methodInfo = classType.GetMethod((String)myDictionary["__MethodName"]);
            return methodInfo;
        }

        public static void SendEmail(string subject, string body)
        {
            try
            {
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                SmtpClient smtp = new SmtpClient();
                mail.To.Add("hcbe2004@gmail.com");
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;
                smtp.Send(mail);
            }
            catch
            {
                return;

            }
        }

        public static String XMLSerializer(object objectSerialized, Type typeOfObject)
        {
            StringWriter stringWriter = null;
            try
            {

                System.Xml.Serialization.XmlSerializer serializer =
                    new System.Xml.Serialization.XmlSerializer(typeOfObject);
                stringWriter = new StringWriter();
                serializer.Serialize(stringWriter, objectSerialized);
                String XML = stringWriter.ToString();
                return XML;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                stringWriter.Close();
            }

        }

        public static object XMLDeserializer(String XML, Type typeOfObject)
        {
            TextReader textReader = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeOfObject);
                textReader = new StringReader(XML);
                return serializer.Deserialize(textReader);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                textReader.Close();
            }
        }


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



        public static MvcHtmlString GetImageTagFromFilePath(string p_FilePath)
        {
            return GetImageTagFromUrlBase64(ToBase64(p_FilePath));
        }

        public static MvcHtmlString GetImageTagFromUrlBase64(string url)
        {
            return GetImageTag("data:image/jpeg;base64," + url);
        }

        public static MvcHtmlString GetImageTag(string url)
        {
            return new MvcHtmlString("<img src=\"" + url + "\" />");
        }

        public static bool SkipAuthetication(AuthorizationContext p_FilterContext)
        {
            bool v_SkipAuthorization =
            p_FilterContext.ActionDescriptor.IsDefined(typeof(AllowAnonymousAttribute), true) ||
            p_FilterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(AllowAnonymousAttribute), true);

            return v_SkipAuthorization;
        }


    }
}
