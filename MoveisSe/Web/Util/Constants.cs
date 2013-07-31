using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util
{
    public static class Constants
    {
        public const String MOVEIS_SANTA_EDWIGES = "Móveis Santa Edwiges";

        public static class Configuration
        {
            public static String RESOURCES_FOLDER_PATH { get { return "IMAGES_DIRECTORY_PATH"; } }
            public static String EMAIL_SERVER_ADDRESS { get { return "EMAIL_SERVER_ADDRESS"; } }
            public static String EMAIL_DEFAULT { get { return "EMAIL_DEFAULT"; } }
            public static String EMAIL_MANAGER { get { return "EMAIL_MANAGER"; } }
            public static String EMAIL_ADMIN { get { return "EMAIL_ADMIN"; } }
        }

        public static class Messages
        {
            public const String MSG_FIELD_REQUIRED = "É obrigatório o preenchimento deste campo";
            public const String MSG_EMAIL_SUBJECT = Constants.MOVEIS_SANTA_EDWIGES + " - Contato pelo site";
        }

        private static class Data
        {
            internal const String ADDRESS_TYPE = "Rua";
            internal const String ADDRESS_NAME = "Joaquim Esteves de Oliveira";
            internal const String ADDRESS_NUMBER = "382";
            internal const String NEIGHBORHOOD = "Jd. São Lucas";
            internal const String CITY = "Alfenas";
            internal const String STATE = "Minas Gerais";
            internal const String STATE_UF = "MG";
            internal const String DDD = "35";
            internal const String PRIMARY_PHONE = "3291-3996";
            internal const String SECUNDARY_PHONE = "8838-3459";
        }

        private static class Format
        {
            internal const String CITY_FORMAT = "{0} - {1}";
            internal const String ADDRESS_FORMAT = "{0} {1}, {2} - {3}";
            internal const String PHONE_FORMAT = "({0}) {1}";
        }

        public static class Information
        {
            public static String CITY { get { return String.Format(Format.CITY_FORMAT, Data.CITY, Data.STATE); } }
            public static String ADDRESS { get { return String.Format(Format.ADDRESS_FORMAT, Data.ADDRESS_TYPE, Data.ADDRESS_NAME, Data.ADDRESS_NUMBER, Data.NEIGHBORHOOD); } }
            public static String COMPLETE_ADDRESS { get { return String.Concat(ADDRESS, " - ", CITY); } }
            public static String PRIMARY_PHONE { get { return String.Format(Format.PHONE_FORMAT, Data.DDD, Data.PRIMARY_PHONE); } }
            public static String SECUNDARY_PHONE { get { return String.Format(Format.PHONE_FORMAT, Data.DDD, Data.SECUNDARY_PHONE); } }
            public static String PRIMARY_EMAIL { get { return ConfigurationReader.GetEmailManager(); } }
            public static String SECUNDARY_EMAIL { get { return ConfigurationReader.GetEmailAdmin(); } }
        }
    }
}
