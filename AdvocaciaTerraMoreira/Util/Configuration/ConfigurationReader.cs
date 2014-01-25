using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util.Configuration
{
    public static class ConfigurationReader
    {
        private static String GetString(String key)
        {
            return System.Configuration.ConfigurationManager.AppSettings[key];
        }

        private static Boolean GetBool(String key)
        {
            string str = GetString(key);
            return Boolean.Parse(str);
        }

        public static int GetMaxContentLength()
        {
            int returnDouble;
            bool success = int.TryParse(GetString("MaxContentLength"), out returnDouble);
            return success? returnDouble : 10000000;
        }

        public static String GetEmailManager()
        {
            return GetString("EmailGerencia");
        }

    }
}
