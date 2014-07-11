using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webTest00.Models;

namespace webTest00.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Get()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Get(int id)
        {
            return View();
        }
    }
}