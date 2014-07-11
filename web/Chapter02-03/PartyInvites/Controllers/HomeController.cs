using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // 2014-06-10 Zhou Kai writes this program:
        // to do something with the View, 
        // with the ViewBag object.

        // The ViewBag object is inherited from
        // the base class of Controller class
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;

            // Please notice that the Greeting property  of ViewBag didin't exist
            // until the moment I assigned the value.
            // This allows me to pass data from the controller to 
            // the view, and in a free and fluid manner(without having to define
            // classes ahead of time, which is sometimes impossible I think)
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            ViewBag.Special = "ViewBag object is special.";

            return View();
        }
    }
}