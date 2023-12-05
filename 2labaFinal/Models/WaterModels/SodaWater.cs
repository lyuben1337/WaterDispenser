namespace Models
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
