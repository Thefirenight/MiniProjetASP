using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Test
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "List",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "List", action = "LightNovels", id = UrlParameter.Optional }
          );

            routes.MapRoute(
               name: "Detail",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Detail", action = " lnDetails", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Accueil", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
