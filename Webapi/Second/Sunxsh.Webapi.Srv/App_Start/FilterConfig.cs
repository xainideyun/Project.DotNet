using System.Web;
using System.Web.Mvc;

namespace Sunxsh.Webapi.Srv
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
