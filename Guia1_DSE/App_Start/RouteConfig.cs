using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Guia1_DSE
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Peliculas", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
            name: "Hola",
            url: "{controller}/{action}/{nombre}/{id}"
            );
        }
    }
}
