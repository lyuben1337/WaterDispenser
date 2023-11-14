using _2labaFinal.Models.DTO;
using _2labaFinal.Models.Machine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2labaFinal
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
