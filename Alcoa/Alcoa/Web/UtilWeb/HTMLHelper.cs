using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.Linq.Expressions;
using System.Globalization;
using System.Web.Mvc.Html;
using System.Xml.Linq;
using Model;

namespace Web.UtilWeb
{
    public static class HTMLHelper
    {
        public static MvcHtmlString CustomValidationSummary(this HtmlHelper htmlHelper, bool excludePropertyErrors)
        {
            var htmlString = htmlHelper.ValidationSummary(excludePropertyErrors);

            if (htmlString != null)
            {
                XElement xEl = XElement.Parse(htmlString.ToHtmlString());

                var lis = xEl.Element("ul").Elements("li");

                if (lis.Count() == 1 && lis.First().Value == "")
                    return null;
                htmlString = new MvcHtmlString("<div class=\"alert alert-error\"><button type=\"button\" class=\"close\" data-dismiss=\"alert\">×</button><strong>Atenção:</strong>" + htmlString + "</div>");
            }

            return htmlString;
        }
    }
}