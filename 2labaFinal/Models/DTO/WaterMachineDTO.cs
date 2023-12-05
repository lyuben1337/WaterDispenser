namespace Models
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
