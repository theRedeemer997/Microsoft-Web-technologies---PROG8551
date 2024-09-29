namespace BmiCalculatorApp.Models
{
    /// <summary>
    /// A class of objects representing the data needed
    /// to view a Bmi calculation
    /// </summary>
    public class BmiViewModel
    {
        public double? Height { get; set; }
        public double? Weight { get; set; }
        public double? Bmi { get; set; }

        /// <summary>
        /// Based on https://www.wikihow.com/Calculate-Your-Body-Mass-Index-%28BMI%29
        /// </summary>
        public static double? CalculateBmi(double? weight, double? height)
        {
            if (weight == null || height == null)
                return null;

            return weight.Value / (height.Value * height.Value);
        }
    }
}
