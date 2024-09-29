using System.ComponentModel.DataAnnotations;

namespace BMI_Application_V1.Models
{
    public class BmiViewModel
    {
        //properties
        [Required(ErrorMessage = "Please enter a height in metres.")]
        //[Range(0.01, 3, ErrorMessage = "Height must be greater than 0 and less than or equal to 3.")]
        [Range(0.01, double.MaxValue)]
        public double? Weight { get; set; }

        [Required(ErrorMessage = "Please enter a weight in kgs.")]
        [Range(3, double.MaxValue)]
        public double? Height { get; set; }
        public double? Bmi { get; set; }

        public string BmiSummary { get; set; }

        public static double? CalculateBmi(double? weight, double? height)
        {
            if (weight == null || height == null) return null;
            return weight.Value/ (height.Value * height.Value);
        }

        public static string GetBmiResultSummary(double? bmi)
        {
            string summary;
            if (bmi > 0.0 && bmi < 18.5)
                summary = "underweight";
            else if (bmi >= 18.5 && bmi < 25.0)
                summary = "normal";
            else if (bmi >= 25.0 && bmi < 30.0)
                summary = "overweight";
            else if (bmi >= 30.0)
                summary = "obese";
            else
                summary = "indetermined";
            return summary;
        }


    }
}
