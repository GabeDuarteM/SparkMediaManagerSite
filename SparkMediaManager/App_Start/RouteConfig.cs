// Developed by: Gabriel Duarte
// 
// Created at: 27/04/2016 23:18

using System.Web.Mvc;
using System.Web.Routing;

namespace SparkMediaManager
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                            "Default",
                            "{controller}/{action}/{id}",
                            new {controller = "Home", action = "Index", id = UrlParameter.Optional}
                );
                
            routes.MapRoute("Default Prettyfied",
                            "{id}",
                            new {controller = "Home", action = "Index", id = UrlParameter.Optional}
                );
        }
    }
}
