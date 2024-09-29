using Microsoft.AspNetCore.Mvc;

namespace BmiCalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
