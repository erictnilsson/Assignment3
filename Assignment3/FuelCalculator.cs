using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class FuelCalculator
    {
        private double OdoCurr { get; set; }
        private double OdoPrev { get; set; }
        private double Fuel { get; set; }
        private double LiterPrice { get; set; }
        private const double KmToMileFactor = 0.62171192;

        public FuelCalculator(double odoCurr, double odoPrev, double fuel, double literPrice)
        {
            this.OdoCurr = odoCurr;
            this.OdoPrev = odoPrev;
            this.Fuel = fuel;
            this.LiterPrice = literPrice; 
        }

        public double GetLiterPerKm()
        {
            double distance = OdoCurr - OdoPrev;

            return Fuel / distance; 
        }

        public double GetKmPerLiter()
        {
            double distance = OdoCurr - OdoPrev;

            return distance / Fuel; 
        }

        public double GetLiterPerMetricMile()
        {
            return GetLiterPerKm() / KmToMileFactor; 
        }

        public double GetLiterPerSwedishMile()
        {
            return GetLiterPerKm() * 10D; 
        }

        public double GetCostPerKm()
        {
            return GetLiterPerKm() * LiterPrice; 
        }
    }
}
