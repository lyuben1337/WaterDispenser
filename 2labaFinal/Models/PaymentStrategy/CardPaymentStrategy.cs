using _2labaFinal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2labaFinal.Models.PaymentStrategy
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
