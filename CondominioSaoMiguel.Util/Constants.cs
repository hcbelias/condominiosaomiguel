using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CondominioSaoMiguel.Util
{
    public static class Constants
    {
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
            public const String MSG_EMAIL_SUBJECT = "Condomínio São Miguel - Contato pelo site"; 
        }
    }
}
