using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Web.Mvc;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Json;
using Util.Configuration;

namespace Util
{
    public class Util
    {
        public static String ToBase64String(String source)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(source));
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



       
    }


}
