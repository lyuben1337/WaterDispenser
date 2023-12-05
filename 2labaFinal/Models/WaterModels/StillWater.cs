namespace Models
{
    public class StillWater : Water
    {
        private double _cost;

        public StillWater(double cost)
        {
            _cost = cost;
        }
        public override double GetCost()
        {
            return _cost;
        }
    }
}
