using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace app_layers
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
				name: "route1",
				url: "{controller}/create/{id}/{name}",
				defaults: new { controller = "Home", action = "create", id = UrlParameter.Optional, name = UrlParameter.Optional }
			); // должен быть сверху иначе перекроет первый роут, 
		}
    }
}
