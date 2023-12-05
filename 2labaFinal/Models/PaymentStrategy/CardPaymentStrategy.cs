namespace Models
{
    public class CardPaymentStrategy : IPaymentStrategy
    {
        public bool Pay(double amount)
        {
            // Transaction realisation for example PayPal
            return true;
        }
    }
}
