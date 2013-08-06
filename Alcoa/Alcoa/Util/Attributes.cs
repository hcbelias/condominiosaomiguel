using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.IO.Compression;

namespace Util.Attributes
{
    public class EmailAttribute : RegularExpressionAttribute
    {
        public EmailAttribute()
            : base("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?")
        {

        }
        public override string FormatErrorMessage(string name)
        {
            return "* Este campo deve obedecer o seguinte formato: xxx@yyy.zzz.uu";
        }
    }

    public class PhoneAttribute : RegularExpressionAttribute
    {
        public PhoneAttribute()
            : base("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?")
        {

        }
        public override string FormatErrorMessage(string name)
        {
            return "* Este campo deve obedecer o seguinte formato: (XX)YYYYZZZZZ";
        }
    }

    public sealed class LogonAuthorize : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext p_FilterContext)
        {
            bool v_SkipAuthorization = Util.SkipAuthetication(p_FilterContext);
            if (!v_SkipAuthorization)
            {
                base.OnAuthorization(p_FilterContext);
            }
        }
    }

    public class CompressAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext p_FilterContext)
        {

            var encodingsAccepted = p_FilterContext.HttpContext.Request.Headers["Accept-Encoding"];
            if (string.IsNullOrEmpty(encodingsAccepted)) return;

            encodingsAccepted = encodingsAccepted.ToLowerInvariant();
            var response = p_FilterContext.HttpContext.Response;

            if (encodingsAccepted.Contains("gzip"))
            {
                response.AppendHeader("Content-encoding", "gzip");
                response.Filter = new GZipStream(response.Filter, CompressionMode.Compress);
            }
            else
                if (encodingsAccepted.Contains("deflate"))
                {
                    response.AppendHeader("Content-encoding", "deflate");
                    response.Filter = new DeflateStream(response.Filter, CompressionMode.Compress);
                }
            HttpContext.Current.Response.AppendHeader("Vary", "Content-Encoding");
        }
    }

    public class FileSizeAttribute : ValidationAttribute
    {
        private readonly int _maxSize;


        public FileSizeAttribute(int maxSize)
        {
            _maxSize = maxSize;
        }

        public override bool IsValid(object value)
        {
            if (value == null) return true;
            return _maxSize > (value as HttpPostedFileWrapper).ContentLength || (value as HttpPostedFileWrapper).ContentLength == 0;
        }

        public override string FormatErrorMessage(string name)
        {
            return string.Format("O tamanho do arquivo não pode exceder {0} Mb", _maxSize / 1000000);
        }
    }

    public class FileTypesAttribute : ValidationAttribute
    {
        private readonly List<string> _types;

        public FileTypesAttribute(string types)
        {
            _types = types.Split(',').ToList();
        }

        public override bool IsValid(object value)
        {
            if (value == null) return true;

            var fileExt = System.IO.Path.GetExtension((value as HttpPostedFileWrapper).FileName).Substring(1);
            return _types.Contains(fileExt, StringComparer.OrdinalIgnoreCase);
        }

        public override string FormatErrorMessage(string name)
        {
            return string.Format("Formato do arquivo inválido. Somente os formatos {0} são suportados.", String.Join(", ", _types));
        }
    }


}