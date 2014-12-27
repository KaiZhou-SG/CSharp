using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace webapi03
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            // zk: GlobalConfiguration provides a global HttpConfiguration for
            // ASP.NET application, by expose a Configuration property, the 
            // Configuration property is namely an static HttpConfiguration 
            // object. This Register method will assign route maps to the 
            // http server instance for the ASP.NET application.
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            // zk: Add filters for the ASP.NET application
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            // zk: Configure / add routes to the RouteTable
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            // zk: enable mapping by attributes
            GlobalConfiguration.Configuration.MapHttpAttributeRoutes();
        }
    }
}