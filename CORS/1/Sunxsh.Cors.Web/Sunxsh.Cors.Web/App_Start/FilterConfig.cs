using System.Web;
using System.Web.Mvc;
using Sunxsh.Cors.Web.Filter;

namespace Sunxsh.Cors.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
//            filters.Add(new ErrorAttribute());
        }
    }
}
