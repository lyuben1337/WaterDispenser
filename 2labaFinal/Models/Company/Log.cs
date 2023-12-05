using System;

namespace Models
{
    public class Log
    {
        public Log()
        {
        }

        public string AutomatId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public WaterType WaterType { get; set; }
        public Payment PaymentType { get; set; }
        public double Volume { get; set; }
        public double Income { get; set; }
        public string Status { get; set; }
    }
}
