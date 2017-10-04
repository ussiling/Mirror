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
                Weatherdesc = "Regnigt och molning under hela dagen men v�xande n�got.",
                Icon = "X",
                Temprature = "13"
            };

            return View(weather);
        }

    }
}