using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BobDemoMVC
{
    public class RouteConfig
    {
        //This method is being called on the Application_Start Eventhandler in the Global.asax.cs
        
            //passing in a collection of routes


        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            //We are populating that RouteColection with new routes that we are creating
            routes.MapRoute(
                name: "Default",
                //the url input parameter defines the pattern that will be matched up.
                //The pattern is defined by a series of in the url (segment is defined by that forward slash in the url)
                url: "{controller}/{action}/{id}",

                //ID is optional
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
