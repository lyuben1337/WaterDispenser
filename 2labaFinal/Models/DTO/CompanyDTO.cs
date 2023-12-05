using System.Collections.Generic;

namespace Models
{
    public class CompanyDTO
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ID { get; set; }

        public double MaxTankVolume;
        public List<WaterMachineDTO> Machines { get; set; }
        public List<WaterTank> Tanks { get; set; }
    }
}
