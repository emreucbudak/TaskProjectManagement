using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Persistence.Errors.NullExceptions;


namespace TaskProjectManagement.Persistence.ActionFilters
{
    public class InsertFilterAttribute : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var controllerName = context.RouteData.Values["controller"];
            var actionName = context.RouteData.Values["action"];

            foreach (var arg in context.ActionArguments)
            {
                if (arg.Value == null)
                {
                    var degisken = arg.Key;
                    Log.Logger.Error($"{controllerName} controllerında {actionName} actionunda  {degisken} null oldugundan gönderilemedi!");
                    throw new ObjectNullExceptions();
                }



            }
        }
    }
}
