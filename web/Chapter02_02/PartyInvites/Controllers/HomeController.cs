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
        // Please notice that, an Index.cshtml file
        // is added to Views/Home folder.

        // This Index.cshtml file is a view, its path
        // together with its name tells us that
        // this view is for Index() action of the 
        // Home controller

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}