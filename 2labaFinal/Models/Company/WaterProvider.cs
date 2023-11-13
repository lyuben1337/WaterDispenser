using _2labaFinal.Models.Machine;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2labaFinal.Models
{
    public class WaterProvider
    {
        public string Name { get; set; } = "default company";
        private HashSet<WaterMachine> _machines = new HashSet<WaterMachine>();
        public double TotalIncome { get; set; } = 0;
        private LinkedList<string> _storage = new LinkedList<string>();
        private List<WaterTank> _tanks = new List<WaterTank>();
        public string Adress { get; set; } = "default address";
        public string ID { get; set; } = "default code"; // EDRPOU code 

        public WaterProvider(string name, string adress, string id, List<WaterTank> waterTanks)
        {
            Name = name;
            Adress = adress;
            ID = id; 
            _tanks = waterTanks;
        }

        void AddMachine(WaterMachine machine)
        {
            _machines.Add(machine);
        }

        void AddLog(string log)
        {
            _storage.AddLast(log);
        }

        void AddWaterTank(WaterTank waterTank)
        {
            _tanks.Add(waterTank);
        }

        public HashSet<WaterMachine> GetMachines()
        {
            return _machines;
        }

        public LinkedList<string> GetStorage()
        {
            return _storage;
        }

        public List<WaterTank> GetTanks()
        {
            return _tanks;
        }
    }
}
