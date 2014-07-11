using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // Actions
        // Any public functions in the 
        // controller class are actions.
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        // add another view for this action
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            // ToDo: Email response to the party organizer
            if (ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }
            else
            {
                // there is a validation error
                return View();
            }
            
        }

    }
}