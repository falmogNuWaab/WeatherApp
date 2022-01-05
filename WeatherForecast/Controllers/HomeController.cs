using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WeatherForecast.Models;

namespace WeatherForecast.Controllers
{
    public class HomeController : Controller
    {
        WeatherDAL wd = new WeatherDAL();
        public IActionResult Index()
        {
            DetroitGrandRapidsWeather dgrw = new DetroitGrandRapidsWeather();
            dgrw.Detroit = wd.GetDetroitWeather();
            dgrw.GrandRapids = wd.GetGrandRapidsWeather();

            return View(dgrw);
        }
        public IActionResult Div()
        {
            DetroitGrandRapidsWeather dgrw = new DetroitGrandRapidsWeather();
            dgrw.Detroit = wd.GetDetroitWeather();
            dgrw.GrandRapids = wd.GetGrandRapidsWeather();

            return View(dgrw);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
