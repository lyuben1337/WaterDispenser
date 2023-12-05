using System;

namespace Models
{
    public class WaterTank
    {
        public double Volume { get; set; }

        public WaterTank(double volume)
        {
            Volume = volume;
        }

        public void TakeWater(double volume)
        {
            if (Volume < volume)
            {
                throw new Exception("Not enough water in the Tank");
            }
            Volume -= volume;
        }

        public void PutWater(double volume)
        {
            Volume += volume;
        }
    }
}
