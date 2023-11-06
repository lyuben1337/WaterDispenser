using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2labaFinal.Models.WaterModels
{
    public class Bottle : WaterDecorator
    {
        private readonly double _count;

        public Bottle(Water water, double count) : base(water)
        {
            _count = count;
        }

        public override double GetCost()
        {
            return _count * (water.GetCost() * 2 + 1.25); // botle volume and price
        }
    }
}
