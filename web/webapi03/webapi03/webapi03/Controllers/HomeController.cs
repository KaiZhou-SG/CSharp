using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
// add mvc packages for returning a view
// which a web api does not have
using System.Web.Mvc;

namespace webapi03.Controllers
{
    // public class HomeController : ApiController
    public class HomeController : Controller
    {
        // this function will be mapped to the
        // default route, and will return the 
        // Index.cshtml as the view(welcome page)
        public ActionResult Index()
        {
            return View();
        }
    }
}
