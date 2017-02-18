using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BobDemoMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            //At the very beginning of the application, when it first starts up, "I need you to go and figure it out
            //all of the route mappings that have been defined."
            //Because all incoming requests are gointg to have to look at a TABLE OF ROUTE PATTERNS to decide where to route that incoming request to.
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
