using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Sunxsh.Jdcat.Api.Filter
{
    public class LogAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            Trace.WriteLine($"Action：{actionContext.ActionDescriptor.ActionName}被执行了，在{DateTime.Now:yyyy-MM-dd}");
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            Trace.WriteLine($"Action：{actionExecutedContext.ActionContext.ActionDescriptor.ActionName}执行完成");
        }
    }
}