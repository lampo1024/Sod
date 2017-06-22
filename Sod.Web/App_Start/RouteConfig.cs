using System.Web.Mvc;
using System.Web.Routing;

namespace Sod.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                 "PostDetails",
                 "{year}/{title}",
                 new { controller = "Post", action = "Details" },
                 new { year = @"\d{4}" }

            );
            routes.MapRoute(
                name: "HomeAction",
                url: "{action}",
                defaults: new { controller = "Home", action = "Index" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
