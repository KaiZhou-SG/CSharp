using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
// for adding new http routes
using System.Web.Http.Routing;

namespace webapi03
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.Add("GetEmployeeById", new HttpRoute(
                "api/{controller}/GetEmployeeById/{Id}"));

            // route map, getting employees by first name
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/GetEmployeeByFirstName/{FirstName}",
                defaults: new { id = RouteParameter.Optional }
            );

            // 2014-12-26 Zhou Kai adds another route map, for creating an
            // employee by providing all fields
            config.Routes.MapHttpRoute(
                name: "CreateEmployeeWithAllFields",
                routeTemplate: 
                  "api/{controller}/{action}/{Id}/{FirstName}/{LastName}/{Gender}"
            );

            // 2014-12-27 Zhou Kai adds another route map, for getting employees
            // by id
            /*
            config.Routes.MapHttpRoute(
                name: "GetEmployeeById",
                routeTemplate:
                  "api/{controller}/{action}/{Id}"
            );
            */

            
        }
    }
}
