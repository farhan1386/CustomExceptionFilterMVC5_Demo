using CustomExceptionFilter_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomExceptionFilter_Demo.CustomeFilters
{
    public class CustomExceptionHandlerFilter : FilterAttribute, IExceptionFilter
    {
        private readonly MvcDemoContext db = new MvcDemoContext();

        public void OnException(ExceptionContext filterContext)
        {
            var exceptionLogger = new ExceptionLogger()
            {
                ExceptionMessage = filterContext.Exception.Message,
                ExceptionStackTrack = filterContext.Exception.StackTrace,
                ControllerName = filterContext.RouteData.Values["controller"].ToString(),
                ActionName = filterContext.RouteData.Values["action"].ToString(),
                ExceptionLogTime = DateTime.Now
             };
            db.ExceptionLoggers.Add(exceptionLogger);
            db.SaveChanges();

            filterContext.ExceptionHandled = true;
            filterContext.Result = new ViewResult
            {
                ViewName = "Error"
            };
        }
    }
}