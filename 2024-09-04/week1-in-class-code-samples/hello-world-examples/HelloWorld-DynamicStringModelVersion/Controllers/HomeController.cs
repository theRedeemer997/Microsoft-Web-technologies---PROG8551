using HelloWorld_DynamicStringModelVersion.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HelloWorld_DynamicStringModelVersion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // first, figure out the hour of the day:
            int hour = DateTime.Now.Hour;

            // then dynamically tailor the greeting message accordingly
            // and store the result in a string, our simple "model" type:
            string greetingMsg = hour < 12 ? "Good morning" : "Good day";

            // And then pass the model off to the view:
            return View("Index", greetingMsg);
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