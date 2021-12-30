using System;
using System.Diagnostics;
using System.Web.Mvc;
using System.Web.Routing;

namespace BookStore.Filters
{
    public class LogActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log("OnActonExecuting", filterContext.RouteData);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Log("OnActionExecuted", filterContext.RouteData);
        }



        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Log("OnResultExceuting", filterContext.RouteData);
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Log("OnResultExecuted", filterContext.RouteData);
        }

        private void Log(string methodName, RouteData routeData)
        {
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];
            var message = String.Format("{0} controller: {1} action: {2}", methodName, controllerName, actionName);

            Debug.WriteLine(message, "ACtion Filter Log");
        }

    }
}
