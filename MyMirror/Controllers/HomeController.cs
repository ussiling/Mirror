using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMirror.Models;

namespace MyMirror.Controllers
{
    public class HomeController : Controller
    {
        //[HttpGet("/")] //Use as start page - change done in Startup.cs for standard
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Mirror()
        {

            //GO TO DATABASE
            var weather = new Weather()
            {
                City = "Bunkeflo",
                Weatherdesc = "Regnigt och molning under hela dagen men växande något.",
                Icon = "X",
                Temprature = "13"
            };

            return View(weather);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
