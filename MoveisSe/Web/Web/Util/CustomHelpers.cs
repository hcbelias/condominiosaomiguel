using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Text;
using System.Web.Mvc;

namespace Web.Util
{
    public static class CustomHelpers
    {
        public static System.Web.Mvc.MvcHtmlString CustomActionLink(this System.Web.Mvc.AjaxHelper Helper, string linkText, string actionName, string controllerName, object routeValues, AjaxOptions ajaxOptions, object htmlAttributes)
        {
            if (ajaxOptions == null)
                ajaxOptions = new AjaxOptions();
            StringBuilder stringLoading = new StringBuilder();
            stringLoading.AppendLine("$('#bodyID').showLoading({");
            stringLoading.AppendLine("'addClass': 'loading-indicator'");
            stringLoading.AppendLine("});");
            ajaxOptions.OnBegin = stringLoading.ToString();
            ajaxOptions.OnComplete = "$('#bodyID').hideLoading()";
            ajaxOptions.OnSuccess = "callOnResizeEvents()";
            return System.Web.Mvc.Ajax.AjaxExtensions.ActionLink(Helper, linkText, actionName, controllerName, routeValues, ajaxOptions, htmlAttributes);
        }

        public static MvcForm CustomBeginForm(this System.Web.Mvc.AjaxHelper Helper, string actionName, string controllerName, object routeValues, AjaxOptions ajaxOptions, object htmlAttributes)
        {
            if (ajaxOptions == null)
                ajaxOptions = new AjaxOptions();
            ajaxOptions.OnSuccess = "callOnResizeEvents()";
            return System.Web.Mvc.Ajax.AjaxExtensions.BeginForm(Helper, actionName, controllerName, routeValues, ajaxOptions, htmlAttributes);
        }
        public static MvcForm CustomBeginForm(this System.Web.Mvc.AjaxHelper Helper, string actionName, string controllerName, AjaxOptions ajaxOptions, object htmlAttributes)
        {
            if (ajaxOptions == null)
                ajaxOptions = new AjaxOptions();
            ajaxOptions.OnSuccess = "callOnResizeEvents()";
            return System.Web.Mvc.Ajax.AjaxExtensions.BeginForm(Helper, actionName, controllerName, ajaxOptions, htmlAttributes);
        }


    }
}