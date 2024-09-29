using BMI_Application_V1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BMI_Application_V1.Controllers
{
    public class BmiController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new BmiViewModel());
        }

        [HttpPost]
        public IActionResult Index(BmiViewModel bmiViewModel)
        {
            if(ModelState.IsValid)
            {
                bmiViewModel.Bmi = BmiViewModel.CalculateBmi(bmiViewModel.Weight, bmiViewModel.Height);
                bmiViewModel.BmiSummary = BmiViewModel.GetBmiResultSummary(bmiViewModel.Bmi);
            }
            return View(bmiViewModel);
        }
    }
}
