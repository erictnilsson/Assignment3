using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Calculators
{
    class BMICalculator
    {
        public Dictionary<float, string> Bmi;

        public BMICalculator()
        {
            Bmi = new Dictionary<float, string>()
            {
                {18.5F, "Underweight" },
                {24.9F, "Normal Weight" },
                {29.9F, "Pre-obesity" },
                {34.9F, "Obesity class 1" },
                {39.9F, "Obesity class 2" },
                {40.0F, "Obesity class 3" }
            };
        }

        public float CalcBMI(bool metric, float height, float weight)
        {
            if (metric)
                return weight / (height * height);
            else
                return 703.0F * weight / (height * height);
        }
    }
}
