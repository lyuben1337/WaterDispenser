namespace Models
{
    public class WaterByVolume : WaterDecorator
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
