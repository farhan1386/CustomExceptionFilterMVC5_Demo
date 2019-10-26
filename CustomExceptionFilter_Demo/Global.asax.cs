using CustomExceptionFilter_Demo.App_Start;
using System.Web.Mvc;
using System.Web.Routing;

namespace CustomExceptionFilter_Demo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilter(GlobalFilters.Filters);
        }
    }
}
