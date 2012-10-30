using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CondominioSaoMiguel.Util
{
    public static class ConfigurationReader
    {
        public static String GetImagesPath()
        {
            return GetValue(Constants.Configuration.RESOURCES_FOLDER_PATH);
        }


        public static String GetValue(String key)
        {
            return System.Configuration.ConfigurationManager.AppSettings[key];
        }

    }
}
