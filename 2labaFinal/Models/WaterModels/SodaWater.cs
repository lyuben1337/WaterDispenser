using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2labaFinal.Models.WaterModels
{
    public class SodaWater : Water
    {
        private double _cost;

        public SodaWater(double cost)
        {
            _cost = cost;
        }

        public override double GetCost()
        {
            return _cost;
        }
    }
}
