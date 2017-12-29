using MVCDay3.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCDay3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                           name: "Default",
                           url: "{controller}/{action}/{id}/{pass}/{token}",
                           defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, pass = UrlParameter.Optional, token = UrlParameter.Optional }

                       );

            routes.MapRoute(
               name: "B",
               url: "{controller}/{action}/{id}/{pass}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }

           );

            routes.MapRoute(
               name: "C",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
               constraints: new { Controller = new NotEqual("admin") }

           );
        }
    }
}
