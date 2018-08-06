using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App1.App_Start
{
    public class CorsFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://localhost");
            base.OnActionExecuting(filterContext);
        }
    }
}