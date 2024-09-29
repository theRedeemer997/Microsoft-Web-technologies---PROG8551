using Microsoft.AspNetCore.Mvc;

using BmiCalculatorApp.Models;

namespace BmiCalculatorApp.Controllers
{
    public class BmiController : Controller
    {
        // This is the version of Index action that handles HTTP GET requests:
        [HttpGet()]
        public IActionResult Index()
        {
            Console.WriteLine("In GET version of Index on Bmi controller");

            // Return an empty BmiViewModel to the view:
            return View(new BmiViewModel());
        }

        // This is the version of Index action that handles HTTP POST requests;
        // ASP.NET Core takes the values in the incoming POST request body
        // and translates them into a BmiViewModel object that is passed as the 
        // param.
        [HttpPost()]
        public IActionResult Index(BmiViewModel bmiViewModel)
        {
            Console.WriteLine("In POST version of Index on Bmi controller");

            // first we'll use the height & weight to calc BMI and
            // use it to update the view model:
            bmiViewModel.Bmi = BmiViewModel.CalculateBmi(bmiViewModel.Weight, bmiViewModel.Height);

            // then return the updated view model to the view:
            return View(bmiViewModel);
        }
    }
}
