using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2labaFinal.Models.WaterModels
{
    internal class WaterByVolume : WaterDecorator
    {
        private double _volume;

        public WaterByVolume(Water water, double volume) : base(water)
        {
            _volume = volume;
        }

        public override double GetCost()
        {
            return water.GetCost() * _volume;
        }
    }
}
