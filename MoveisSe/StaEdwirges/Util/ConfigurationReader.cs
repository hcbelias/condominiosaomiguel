using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util
{
    public static class ConfigurationReader
    {
        public static String GetImagesPath()
        {
            return GetValue(Constants.Configuration.RESOURCES_FOLDER_PATH);
        }

        public static String GetEmailServerAddress()
        {
            return GetValue(Constants.Configuration.EMAIL_SERVER_ADDRESS);
        }

        public static String GetEmailManager()
        {
            return GetValue(Constants.Configuration.EMAIL_MANAGER);
        }

        public static String GetEmailAdmin()
        {
            return GetValue(Constants.Configuration.EMAIL_ADMIN);
        }

        public static String GetEmailDefault()
        {
            return GetValue(Constants.Configuration.EMAIL_DEFAULT);
        }

        public static String GetValue(String key)
        {
            return System.Configuration.ConfigurationManager.AppSettings[key];
        }

    }
}
