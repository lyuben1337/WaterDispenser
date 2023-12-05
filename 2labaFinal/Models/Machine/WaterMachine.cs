using System;

namespace Models
{
    public class WaterMachine
    {
        public string Address { get; set; } = "default";
        private IPaymentStrategy _paymentStrategy;
        public readonly CashPaymentStrategy CashPaymentStrategy = new CashPaymentStrategy();
        public readonly CardPaymentStrategy CardPaymentStrategy = new CardPaymentStrategy();
        private Payment selectedPaymentType = Payment.Card;
        private Water _selectedWater;
        private WaterVendingMachine _waterVendingMachine;
        public WaterTank WaterTank { get; set; }
        public double _stillWaterPrice { get; set; } = 12;
        public double _sodaWaterPrice { get; set; } = 10;
        private double _waterTankMaxVolume = 1000;
        public int BottleCount { get; set; } = 0;
        private const double BottleVolume = 2;
        private double _waterVolume;
        private int _bottleBuyedCount = 0;
        public double Income { get; set; } = 0;
        public bool PayWithCard { get; set; } = false;
        public bool SellBottles { get; set; } = false;
        public bool SellSoda { get; set; } = false;
        private int _companyId = 0;

        public delegate void OrderPlacedEventHandler(object sender, OrderPlacedEventArgs e);
        public event OrderPlacedEventHandler OrderPlaced;
        public delegate void WaterDepletedEventHandler(object sender, WaterDepletedEventArgs e);
        public event WaterDepletedEventHandler WaterDepleted;

        public int CompanyID { get { return _companyId; } set { _companyId = value; } }

        public WaterMachine() {
            WaterTank = new WaterTank(_waterTankMaxVolume);
            _waterVendingMachine = new WaterVendingMachine(null, null);
        }

        public WaterMachine(double stillWaterPrice, double sodaWaterPrice, double waterTankMaxVolume, int bottleCount, string address, int companyId)
        {
            _stillWaterPrice = stillWaterPrice;
            _sodaWaterPrice = sodaWaterPrice;
            _waterTankMaxVolume = waterTankMaxVolume;
            BottleCount = bottleCount;
            _waterVendingMachine = new WaterVendingMachine(null, null);
            WaterTank = new WaterTank(waterTankMaxVolume);
            Address = address;
            _companyId = companyId;
        }

        public int GetCompanyID() { return _companyId; }

        public bool SelectPaymentStrategy(Payment payment)
        {
            switch (payment)
            {
                case Payment.Card:
                    if (!PayWithCard)
                    {
                        throw new InvalidOperationException("Card payments unfortunatly is not posibble now!");
                    }
                    _paymentStrategy = CardPaymentStrategy;
                    selectedPaymentType = Payment.Card;
                    break;
                case Payment.Cash:
                    _paymentStrategy = CashPaymentStrategy;
                    selectedPaymentType = Payment.Cash;
                    break;
                default:
                    return false;
            }

            _waterVendingMachine.SetPaymentStrategy(_paymentStrategy);

            return true;
        }

        public bool SelectWater(WaterType type)
        {
            switch (type)
            {
                case WaterType.Soda:
                    if(!SellSoda)
                    {
                        throw new InvalidOperationException("Sode is not sold now!");
                    }
                    _selectedWater = new SodaWater(_sodaWaterPrice);
                    break;
                case WaterType.Still:
                    _selectedWater = new StillWater(_stillWaterPrice);
                    break;
                default:
                    return false;
            }

            return true;
        }

        public bool BuyWithBottles(int bottleCount)
        {
            if(SellBottles)
            {
                if (bottleCount > BottleCount)
                {
                    throw new ArgumentException("Not enough bottles in the machine");
                }
                if (bottleCount * BottleVolume > WaterTank.Volume)
                {
                    throw new ArgumentException("Not enough water in the tank!");
                }
                _bottleBuyedCount = bottleCount;
                _waterVolume = bottleCount * BottleVolume;
                _waterVendingMachine.SetWater(new Bottle(_selectedWater, bottleCount));
                return true;
            }
            throw new InvalidOperationException("Bottles are not sold now!");
        }

        public bool BuyWithVolume(double volume)
        {
            if (volume > WaterTank.Volume)
            {
                throw new ArgumentException("Not enough water in the tank!");
            }
            _waterVolume = volume;
            _waterVendingMachine.SetWater(new WaterByVolume(_selectedWater, volume));
            return true;
        }

        public bool BuyWater()
        {
            if (_waterVendingMachine.BuyWater())
            {
                var eventArgs = new OrderPlacedEventArgs();
                BottleCount -= _bottleBuyedCount;
                WaterTank.TakeWater(_waterVolume);
                if (WaterTank.Volume == 0)
                {

                    WaterDepleted?.Invoke(this, new WaterDepletedEventArgs
                    {
                        WaterMachine = this,
                        AutomatId = $"ID{_companyId.ToString()}_{Address}",
                    }) ;
                }
                if(_bottleBuyedCount > 0)
                {
                    eventArgs.OrderedVolume = _bottleBuyedCount * BottleVolume;
                } else
                {
                    eventArgs.OrderedVolume = _waterVolume;
                }
                Income += GetCost();
                eventArgs.PurchaseDate = DateTime.Now;
                eventArgs.AutomatId = $"ID{_companyId.ToString()}_{Address}";
                eventArgs.Income = GetCost();
                eventArgs.Status = "SUCCESS";
                eventArgs.PaymentType = selectedPaymentType;
                OrderPlaced?.Invoke(this, eventArgs);
                _bottleBuyedCount = 0;
                _waterVolume = 0;
                return true;
            };
            _bottleBuyedCount = 0;
            _waterVolume = 0;
            return false;
        }

        public double GetCost()
        {
            return _waterVendingMachine.GetCost();
        }
    }

    public class OrderPlacedEventArgs : EventArgs
    {
        public double OrderedVolume { get; set; }
        public Payment PaymentType { get; set; }
        public double Income { get; set; }
        public string AutomatId { get; set; }
        public string Status { get; set; }
        public DateTime PurchaseDate { get; set; }
        public WaterType WaterType { get; set; }

    }

    public class WaterDepletedEventArgs : EventArgs
    {
        public WaterMachine WaterMachine { get; set; }
        public string AutomatId { get; set; }

    }
}
