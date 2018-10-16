using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class FuelCalculator
    {
        public double CurrReading { get; set; }
        public double FuelAmount { get; set; }
        public double PrevReading { get; set; }
        public double UnitPrice { get; set; }

        public FuelCalculator() { }

        public FuelCalculator(double currReading, double fuelAmount, double prevReading, double unitPrice)
        {
            // The "this."-declarations are redundant but I feel that they add some clarity since the parameter- and member naming conventions differ very little
            this.CurrReading = currReading;
            this.FuelAmount = fuelAmount;
            this.PrevReading = prevReading;
            this.UnitPrice = unitPrice;
        }

        public double CalcConsumptionKmPerLiter()
        {
            return GetDistance() / FuelAmount;
        }

        public double CalcCostPerKm()
        {
            return CalcFuelConsumptionPerKm() * UnitPrice;
        }

        public double CalcFuelConsumptionPerKm()
        {
            return FuelAmount / GetDistance();
        }

        public double CalcFuelConsumptionPerSweMil()
        {
            return CalcFuelConsumptionPerKm() * 10D;
        }

        public double CalcFuelConsumptionperMetricMile()
        {
            return CalcFuelConsumptionPerKm() / 0.621371192D;
        }

        public bool ValidateValues()
        {
            return true;
        }

        private double GetDistance()
        {
            return CurrReading - PrevReading;
        }
    }
}
