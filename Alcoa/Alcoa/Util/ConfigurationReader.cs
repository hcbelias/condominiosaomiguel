using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util
{
    public static class ConfigurationReader
    {
        private static String GetString(String key)
        {
            return System.Configuration.ConfigurationManager.AppSettings[key];
        }

        public static int GetMaxContentLength()
        {
            int returnDouble;
            bool success = int.TryParse(GetString("MaxContentLength"), out returnDouble);
            return success ? returnDouble : 10000000;
        }

        public static string GetImagesPath()
        {
            string path = GetString("ImagesPath");
            return string.IsNullOrWhiteSpace(path) ? "Imagens/" : path;
        }

    }
}
