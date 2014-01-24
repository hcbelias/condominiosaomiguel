using System.Web.Mvc;
using Util.Attributes;

namespace AdvocaciaTerraMoreira
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new RequireHttpsAttribute());
        }
    }
}