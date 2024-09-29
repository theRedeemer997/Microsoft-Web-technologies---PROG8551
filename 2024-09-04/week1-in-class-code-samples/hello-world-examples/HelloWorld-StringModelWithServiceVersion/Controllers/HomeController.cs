using HelloWorld_StringModelWithServiceVersion.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

using HelloWorld_StringModelWithServiceVersion.Services;

namespace HelloWorld_StringModelWithServiceVersion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(IGreetingService greetingService, ILogger<HomeController> logger)
        {
            Console.WriteLine("In HomeController constructor");
            _greetingService = greetingService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var greetingMsg = _greetingService.GetGreeting();
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

        private IGreetingService _greetingService;
    }
}