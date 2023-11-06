using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2labaFinal.Models.WaterModels
{
    public abstract class WaterDecorator : Water
    {
        protected Water water;

        public WaterDecorator(Water water)
        {
            this.water = water;
        }
    }
}
