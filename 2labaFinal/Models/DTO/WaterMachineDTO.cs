using _2labaFinal.Models.Machine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2labaFinal.Models.DTO
{
    public class WaterMachineDTO
    {
        public string Address { get; set; }
        public WaterTank WaterTank { get; set; }
        public double _stillWaterPrice { get; set; }
        public double _sodaWaterPrice { get; set; }
        public int BottleCount { get; set; }
        public double Income {  get; set; }
        public bool PayWithCard { get; set; }
        public bool SellBottles { get; set; }
        public bool SellSoda { get; set; }
    }
}
