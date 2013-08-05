using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

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
    }
}
