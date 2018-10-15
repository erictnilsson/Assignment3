using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{ // error handle pls
    class FuelCalculatorController
    {
        private FuelCalculator fc; 

        public FuelCalculatorController(double odoCurr, double odoPrev, double fuel, double literPrice)
        {
            fc = new FuelCalculator(odoCurr, odoPrev, fuel, literPrice); 
        }

        public double GetLiterPerKm()
        {
            return fc.GetLiterPerKm(); 
        }

        public double GetKmPerLiter()
        {
            return fc.GetKmPerLiter(); 
        }

        public double GetLiterPerMetricMile()
        {
            return fc.GetLiterPerMetricMile(); 
        }

        public double GetLiterPerSwedishMile()
        {
            return fc.GetLiterPerSwedishMile(); 
        }

        public double GetCostPerKm()
        {
            return fc.GetCostPerKm(); 
        }
    }
}
