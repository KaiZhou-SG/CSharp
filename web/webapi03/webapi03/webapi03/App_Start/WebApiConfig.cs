using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace webapi03
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{FirstName}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "CreateEmployee",
                routeTemplate: 
                  "api/{controller}/{action}/{Id}/{FirstName}/{LastName}/{Gender}"
            );

            
        }
    }
}
