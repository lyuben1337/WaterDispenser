namespace Models
{
    public class WaterVendingMachine
    {
        private IPaymentStrategy _paymentStrategy;
        private Water _water;

        public WaterVendingMachine(IPaymentStrategy paymentStrategy, Water water)
        {
            _paymentStrategy = paymentStrategy;
            _water = water;
        }

        public bool BuyWater()
        {
            double cost = _water.GetCost();
            return _paymentStrategy.Pay(cost);
        }

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void SetWater(Water water)
        {
            _water = water;
        }

        public double GetCost()
        {
            return _water.GetCost();
        }

    }
}
