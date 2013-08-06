﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace System.Web.Mvc
{
    using System.Globalization;
    using Linq;
    using Text;

    public static class HtmlHelperExtension
    {
        public static Html5Form Html5Form(this HtmlHelper instance)
        {
            return new Html5Form(instance);
        }
    }

    public class Html5Form
    {
        private readonly HtmlHelper htmlHelper;

        public Html5Form(HtmlHelper htmlHelper)
        {
            this.htmlHelper = htmlHelper;
        }

        private static CultureInfo Culture { get { return CultureInfo.CurrentCulture; } }

        public virtual IHtmlString InputText()
        {
            return Build("text");
        }

        public virtual IHtmlString InputEmail()
        {
            return Build("email");
        }

        public virtual IHtmlString InputUrl()
        {
            return Build("url");
        }

        public virtual IHtmlString InputNumber()
        {
            return Build("number");
        }

        public virtual IHtmlString InputRange()
        {
            return Build("range");
        }

        public virtual IHtmlString InputPassword()
        {
            return Build("password");
        }

        public virtual IHtmlString InputTelephone()
        {
            return Build("tel");
        }

        public virtual IHtmlString InputDate()
        {
            return BuildDateTimePicker("datepicker");
        }

        public virtual IHtmlString InputTime()
        {
            return BuildDateTimePicker("timepicker");
        }

        public virtual IHtmlString InputDateTime()
        {
            return BuildDateTimePicker("datetimepicker");
        }

        private IHtmlString BuildDateTimePicker(string p_Type)
        {
            var viewData = htmlHelper.ViewData;
            var metadata = viewData.ModelMetadata;

            var placeHolder = !string.IsNullOrWhiteSpace(metadata.Watermark) ? "placeholder=\"" + metadata.Watermark + "\"" : string.Empty;
            var value = viewData.TemplateInfo.FormattedModelValue.ToString();
            DateTime valueTest;
            DateTime.TryParse(value, out valueTest);
            if (valueTest == DateTime.MinValue)
                value = "";
            var valueAttribute = !string.IsNullOrWhiteSpace(value) ? "value=\"" + value + "\"" : string.Empty;
            var id = viewData.TemplateInfo.GetFullHtmlFieldId(string.Empty);
            var name = viewData.TemplateInfo.GetFullHtmlFieldName(string.Empty);
            var cssClass = " ";

            var dateFormat = "dd/MM/yyyy hh:mm";

            if (p_Type == "datepicker")
                dateFormat = "dd/MM/yyyy";
            else if (p_Type == "timepicker")
                dateFormat = "hh:mm";

            ModelState state;

            if (viewData.ModelState.TryGetValue(name, out state) && (state.Errors.Count > 0))
            {
                cssClass += " " + HtmlHelper.ValidationInputCssClassName;
            }

            var validators = GetValidators(metadata);

            string input = string.Format(Culture,
                "<input type=\"{0}\" id=\"{1}\" name=\"{2}\" data-format=\"" + dateFormat + "\" class=\"{3}\" {4} {5} {6} />",
                "text", id, name, cssClass, valueAttribute, placeHolder, validators);
            string div = "<div class=\"input-append " + p_Type + "\">{0}{1}</div>";
            string span = "<span class=\"add-on\"><i data-time-icon=\"icon-time\" data-date-icon=\"icon-calendar\"></i></span>";


            return MvcHtmlString.Create(string.Format(div, input, span));
        }

        private IHtmlString Build(string type)
        {
            var viewData = htmlHelper.ViewData;
            var metadata = viewData.ModelMetadata;

            var placeHolder = !string.IsNullOrWhiteSpace(metadata.Watermark) ? "placeholder=\"" + metadata.Watermark + "\"" : string.Empty;
            var value = viewData.TemplateInfo.FormattedModelValue.ToString();
            var valueAttribute = !string.IsNullOrWhiteSpace(value) ? "value=\"" + value + "\"" : string.Empty;
            var id = viewData.TemplateInfo.GetFullHtmlFieldId(string.Empty);
            var name = viewData.TemplateInfo.GetFullHtmlFieldName(string.Empty);
            var cssClass = "text-box single-line";

            ModelState state;

            if (viewData.ModelState.TryGetValue(name, out state) && (state.Errors.Count > 0))
            {
                cssClass += " " + HtmlHelper.ValidationInputCssClassName;
            }

            var validators = GetValidators(metadata);

            string input = string.Format(Culture,
                "<input type=\"{0}\" id=\"{1}\" name=\"{2}\" class=\"{3}\" {4} {5} {6}/>", type, id, name, cssClass, valueAttribute, placeHolder, validators);

            return MvcHtmlString.Create(input);
        }



        private string GetValidators(ModelMetadata metadata)
        {
            var unobtrusiveJavaScriptEnabled = htmlHelper.ViewContext.UnobtrusiveJavaScriptEnabled;

            var rules = new StringBuilder();
            var validatorsDictionary = ModelValidatorProviders.Providers
                                                              .GetValidators(metadata, htmlHelper.ViewContext)
                                                              .SelectMany(v => v.GetClientValidationRules());

            foreach (var rule in validatorsDictionary)
            {
                if (rule is ModelClientValidationRequiredRule)
                {
                    rules.Append(" required=\"required\"");

                    if (unobtrusiveJavaScriptEnabled)
                    {
                        rules.AppendFormat(Culture, " data-val-required=\"{0}\"", HttpUtility.HtmlEncode(rule.ErrorMessage ?? string.Empty));
                    }

                }
                else if (rule is ModelClientValidationRegexRule)
                {
                    rules.AppendFormat(Culture, " pattern=\"{0}\"", rule.ValidationParameters["pattern"]);

                    if (unobtrusiveJavaScriptEnabled)
                    {
                        rules.AppendFormat(Culture, " data-val-pattern=\"{0}\"", HttpUtility.HtmlEncode(rule.ErrorMessage ?? string.Empty));
                    }
                }
                else if (rule is ModelClientValidationRangeRule)
                {
                    rules.AppendFormat(Culture, " min=\"{0}\"", rule.ValidationParameters["min"]);
                    rules.AppendFormat(Culture, " max=\"{0}\"", rule.ValidationParameters["max"]);

                    if (unobtrusiveJavaScriptEnabled)
                    {
                        rules.AppendFormat(Culture, " data-val-range=\"{0}\"", HttpUtility.HtmlEncode(rule.ErrorMessage ?? string.Empty));
                    }
                }
                else
                {
                    if (!unobtrusiveJavaScriptEnabled)
                    {
                        continue;
                    }

                    var dictionaryKey = "data-val-" + rule.ValidationType;

                    rules.AppendFormat(Culture, " {0}=\"{1}\"", dictionaryKey, HttpUtility.HtmlEncode(rule.ErrorMessage));

                    dictionaryKey = dictionaryKey + "-";

                    foreach (var pair in rule.ValidationParameters)
                    {
                        rules.AppendFormat(Culture, " {0}=\"{1}\"", dictionaryKey + pair.Key, HttpUtility.HtmlEncode(pair.Value));
                    }
                }
            }


            return rules.ToString();
        }
    }
}