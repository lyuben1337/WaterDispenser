namespace Models
{
    public interface IPaymentStrategy
    {
        bool Pay(double amount);
    }
}
