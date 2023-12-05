using System;

namespace Models
{
    public class CashPaymentStrategy : IPaymentStrategy
    {
        private double _cash;

        public bool Pay(double amount)
        {
            if (_cash >= amount)
            {
                _cash -= amount;
            }
            else
            {
                _cash = 0;
                throw new ArgumentException("Not enough money!");
            }
            return true;
        }

        public void PutCash(double amount)
        {
            _cash += amount;
        }

        public double TakeChange()
        {
            var change = _cash;
            _cash = 0;
            return change;
        }
    }
}
