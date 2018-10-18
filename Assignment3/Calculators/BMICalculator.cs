using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Calculators
{
    class BMICalculator
    {
        public bool Metric { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }

        public Dictionary<float, string> Categories { get; set; }

        public BMICalculator()
        {
            Categories = new Dictionary<float, string>()
            {
                {18.5F, "Underweight" },
                {24.9F, "Normal Weight" },
                {29.9F, "Pre-obesity" },
                {34.9F, "Obesity class 1" },
                {39.9F, "Obesity class 2" },
                {float.MaxValue, "Obesity class 3" }
            };
        }

        public BMICalculator(bool metric, float height, float weight)
        {
            this.Metric = metric;
            this.Height = height;
            this.Weight = weight; 
            Categories = new Dictionary<float, string>()
            {
                {18.5F, "Underweight" },
                {24.9F, "Normal Weight" },
                {29.9F, "Pre-obesity" },
                {34.9F, "Obesity class 1" },
                {39.9F, "Obesity class 2" },
                {float.MaxValue, "Obesity class 3" }
            };
        }

        public float CalcBMI()
        {
            if (Metric)
            {
                Height = Height / 100; 
                return Weight / (Height * Height);
            }
                
            else
                return 703.0F * Weight / (Height * Height);
        }

        public string CalcCategory(float bmi)
        {
           foreach (var k in Categories)
            {
                if (bmi <= k.Key)
                    return k.Value;
            }
            return null; 
        }
    }
}
