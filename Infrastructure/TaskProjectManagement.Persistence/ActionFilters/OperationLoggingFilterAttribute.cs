using Microsoft.AspNetCore.Mvc.Filters;
using Serilog;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Persistence.ActionFilters
{
    public class OperationLoggingFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var controllerName = context.RouteData.Values["controller"];
            var actionName = context.RouteData.Values["action"];
            var methodName = context.HttpContext.Request.Method;
            var statusCode = context.HttpContext.Response.StatusCode;
            Log.Logger.Information($"[BILGI] {controllerName} controllerında {actionName} actionunda {methodName} methoduyla {statusCode} kodlu işlem yapılmıştır!");
        }
    }
}
