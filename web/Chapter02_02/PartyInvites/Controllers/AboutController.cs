using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class AboutController : Controller
    {
        // 2014-06-16 Zhou Kai adds this controller
        // and a view for it. This is a practice for
        // adding Controller and its corresponding View.
        // Access this new controller via:
        // "localhost:portnumber/About"
        // GET: About
        public ActionResult Index()
        {
            return View();
        }
    }
}