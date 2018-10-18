using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Calculators
{
    class BMRCalculator
    {
        public float Bmr { get; set; }
        public bool Female { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public float Age { get; set; }
        public Dictionary<int, float> Factors { get; set; }


        public BMRCalculator(bool female)
        {
            Female = female; 

            Factors = new Dictionary<int, float>
            {
                {0, 1.2F },
                {1, 1.375F },
                {2, 1.550F },
                {3, 1.725F },
                {4, 1.9F }
            };
        }

        public BMRCalculator()
        {
            Factors = new Dictionary<int, float>
            {
                {0, 1.2F },
                {1, 1.375F },
                {2, 1.550F },
                {3, 1.725F },
                {4, 1.9F }
            }; 
        }

        public float CalcBaseBmr()
        {
            float bmr = 0F;

            bmr = (10F * Weight) + (6.25F * Height) - (5 * Age);

            if (Female)
            {
                bmr -= 161F; 
            } else
            {
                bmr += 5F; 
            }
            return bmr; 
        }

        public float CalcFactoredBmr(int group)
        {
            foreach (var key in Factors)
            {
                if (group == key.Key)
                {
                    return CalcBaseBmr() * key.Value; 
                }
            }
            return 0F; 
        }
    }
}
