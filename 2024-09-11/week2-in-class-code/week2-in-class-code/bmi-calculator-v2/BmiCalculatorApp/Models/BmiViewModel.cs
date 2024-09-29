using System.ComponentModel.DataAnnotations;

namespace BmiCalculatorApp.Models
{
    /// <summary>
    /// A class of objects representing the data needed
    /// to view a Bmi calculation
    /// </summary>
    public class BmiViewModel
    {
        [Required(ErrorMessage = "Please enter a height in metres.")]
        [Range(0.01, 3, ErrorMessage = "Height must be greater than 0 and less than or equal to 3.")]
        public double? Height { get; set; }

        [Required(ErrorMessage = "Please enter a weight in Kgs.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Weight must be greater than 0.")]
        public double? Weight { get; set; }

        public double? Bmi { get; set; }

        public string? BmiSummary { get; set; }

        /// <summary>
        /// Based on https://www.wikihow.com/Calculate-Your-Body-Mass-Index-%28BMI%29
        /// </summary>
        public static double? CalculateBmi(double? weight, double? height)
        {
            if (weight == null || height == null)
                return null;

            return weight.Value / (height.Value * height.Value);
        }

        public static string GetBmiResultSummary(double? bmi)
        {
            if (bmi == null)
                return string.Empty;

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
