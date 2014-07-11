using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home, in RouteConfig.cs,
        // Index is configed as the default web page for this web application.
        public string Index()
        {
            return "Hello, World!";
        }
    }
}