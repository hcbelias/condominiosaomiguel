using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Util
{
    public class HtmlHelper
    {
        private const string BASE64_IMAGE_TAG_SOURCE_PREFFIX = "data:image/jpeg;base64,";
        public static MvcHtmlString GetImageTagFromFilePath(string p_FilePath)
        {
            return GetImageSourceFromUrlBase64(Util.ToBase64(p_FilePath));
        }

        public static MvcHtmlString GetImageSourceFromFilePath(string p_FilePath)
        {
            return new MvcHtmlString(BASE64_IMAGE_TAG_SOURCE_PREFFIX + Util.ToBase64(p_FilePath));
        }

        public static MvcHtmlString GetImageSourceFromUrlBase64(string p_Base64)
        {
            return GetImageTag(BASE64_IMAGE_TAG_SOURCE_PREFFIX + p_Base64);
        }

        public static MvcHtmlString GetImageTag(string p_Source)
        {
            return new MvcHtmlString("<img src=\"" + p_Source + "\" />");
        }

    }
}