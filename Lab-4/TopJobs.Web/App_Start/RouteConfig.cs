using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TopJobs.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Contact",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Contact", action = "Contact", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Create",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Create", action = "Create", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "List",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "List", action = "List", id = UrlParameter.Optional }
           );

            routes.MapRoute(
              name: "Details",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Details", action = "Details", id = UrlParameter.Optional }
          );

            routes.MapRoute(
            name: "Delete",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Delete", action = "Delete", id = UrlParameter.Optional }
        );

            routes.MapRoute(
            name: "Login",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Login", action = "Login", id = UrlParameter.Optional }
        );

            routes.MapRoute(
                        name: "Register",
                        url: "{controller}/{action}/{id}",
                        defaults: new { controller = "Register", action = "Register", id = UrlParameter.Optional }
                    );
        }
    }
}
