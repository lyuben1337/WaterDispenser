using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Models
{
    public class WaterProvider
    {
        public string Name { get; set; } = "default company";
        private List<WaterMachine> _machines = new List<WaterMachine>();
        private HashSet<string> _machinesAddreses = new HashSet<string>();
        private LinkedList<Log> _storage = new LinkedList<Log>();
        private List<WaterTank> _tanks = new List<WaterTank>();
        public string Adress { get; set; } = "default address";
        public string ID { get; set; } = "default code"; // EDRPOU code 
        public double MaxTankVolume { get; set; } = 0;


        public List<WaterMachine> Machines 
        { 
            get { return _machines; }
            set {  _machines = value; }
        }

        public List<WaterTank> Tanks
        {
            get { return _tanks; }
            set { _tanks = value; }
        }

        public WaterProvider(string name, string adress, string id, List<WaterTank> waterTanks)
        {
            Name = name;
            Adress = adress;
            ID = id; 
            _tanks = waterTanks;
            MaxTankVolume = _tanks[0].Volume;
        }

        public void AddMachine(WaterMachine machine)
        {
            machine.OrderPlaced += OnOrderPlaced;
            machine.WaterDepleted += OnWaterDepleted;
            _machines.Add(machine);
            _machinesAddreses.Add(machine.Address);
        }

        public void AddLog(Log log)
        {
            _storage.AddLast(log);
        }

        public void AddWater(double volume, int tankNubmer)
        {
            if (tankNubmer < 0 || tankNubmer >= _tanks.Count)
                throw new Exception($"Tank with number {tankNubmer} not found!");

            _tanks[tankNubmer].Volume = Math.Min(MaxTankVolume, _tanks[tankNubmer].Volume + volume);
        }

        public void TakeWater(double volume)
        {
            if (!isEnoughWaterInTanks(volume))
                throw new Exception("Not enough water in tanks!");

            double remainingVolume = volume;

            foreach (WaterTank tank in _tanks)
            {
                if (tank.Volume >= remainingVolume)
                {
                    tank.TakeWater(remainingVolume);
                    remainingVolume = 0;
                    break;
                }
                else
                {
                    double takenFromTank = tank.Volume;
                    tank.TakeWater(takenFromTank);
                    remainingVolume -= takenFromTank;
                }
            }

        }

        public double GetIncome()
        {
            return _machines.Sum(m => m.Income);
        }

        public void RemoveMachine(int index)
        {
            _machines.RemoveAt(index);
        }

        private bool isEnoughWaterInTanks(double volume)
        {
            return volume <= _tanks.Sum(el => el.Volume);
        }

        public List<WaterMachine> GetMachines()
        {
            return _machines;
        }

        public LinkedList<Log> GetStorage()
        {
            return _storage;
        }

        public List<WaterTank> GetTanks()
        {
            return _tanks;
        }

        public HashSet<string> GetNamesOfMachines()
        {
            return _machinesAddreses;
        }

        private void OnOrderPlaced(object sender, OrderPlacedEventArgs e)
        {
            Log log = new Log
            {
                Volume = e.OrderedVolume,
                PaymentType = e.PaymentType,
                Income = e.Income,
                AutomatId = e.AutomatId,
                Status = e.Status,
                PurchaseDate = e.PurchaseDate,
                WaterType = e.WaterType
            };
            AddLog(log);
        }

        private void OnWaterDepleted(object sender, WaterDepletedEventArgs e)
        {
            Log log = new Log
            {
                Status = "WATER DEPLETED",
                PurchaseDate = DateTime.Now,
                AutomatId = e.AutomatId
            };
            AddLog(log);
            try
            {
                sendCourier(e.WaterMachine, 100);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void sendCourier(WaterMachine waterMachine, double volume)
        {
            this.TakeWater(volume);
            waterMachine.WaterTank.PutWater(volume);
            MessageBox.Show("Courier added water!");
        }
    }
}
