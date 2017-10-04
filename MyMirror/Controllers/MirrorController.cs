using Microsoft.AspNetCore.Mvc;
using MyMirror.Models;

namespace MyMirror.Controllers
{
    public class MirrorController : Controller
    {
        public IActionResult Index()
        {
            var weather = new WeatherItem()
            {
                City = "Bunkeflo",
                Weatherdesc = "Regnigt och molning under hela dagen men växande något.",
                Icon = "X",
                Temprature = "13"
            };

            return View(weather);
        }

    }
}