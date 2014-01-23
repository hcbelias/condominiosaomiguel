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
            return string.Format("O tamanho do arquivo não pode exceder {0} Mb", _maxSize/1000000);
        }
    }
}