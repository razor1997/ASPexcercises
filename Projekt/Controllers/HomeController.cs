using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projekt.Models;

namespace Projekt.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greetings = hour > 17 ? "Dzień dobry" : "Dobry wieczór";
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GueastResponse guestResponse)
        {
            if (ModelState.IsValid)
                return View("Thanks", guestResponse);
            else
                return View();
        }
    }
}