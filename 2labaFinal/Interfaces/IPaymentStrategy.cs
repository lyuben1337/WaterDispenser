using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2labaFinal.Interfaces
{
    internal interface IPaymentStrategy
    {
        bool Pay(double amount);
    }
}
