using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;


namespace Util
{
    public class Constants
    {   
        public const string FACEBOOK_USER_DENIED = "user_denied";
        public const string FACEBOOK_ERROR_REASON = "error_reason";
        public const string NOT_AUTHORIZED = "not_authorized";
        public const string SERVICE_ERROR_FORMAT = "Erro de serviço - {0}";
        public const string SERVICE_SUCCESS_FORMAT = "success";
        public static string MSG_CONTACT_EMAIL_SUBJECT = String.Format("{0} - {1}", Internationalization.EnterpriseName, "Contato pelo site");
    }
}
