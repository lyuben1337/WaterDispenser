using _2labaFinal.Enums;
using _2labaFinal.Interfaces;
using _2labaFinal.Models.PaymentStrategy;
using _2labaFinal.Models.WaterModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2labaFinal.Models.Machine
{
    internal class WaterMachine
    {
        public string Address;
        private IPaymentStrategy _paymentStrategy;
        public readonly CashPaymentStrategy CashPaymentStrategy = new CashPaymentStrategy();
        public readonly CardPaymentStrategy CardPaymentStrategy = new CardPaymentStrategy();
        private Water _selectedWater;
        private WaterVendingMachine _waterVendingMachine;
        public WaterTank WaterTank;
        public readonly double _stillWaterPrice;
        public readonly double _sodaWaterPrice;
        private readonly double _waterTankMaxVolume;
        public int BottleCount;
        private const double BottleVolume = 2;
        private double _waterVolume;
        private int _bottleBuyedCount = 0;
        public double Income = 0;
        public bool PayWithCard = true;
        public bool SellBottles = true;
        public bool SellSoda = true;

        public WaterMachine(double stillWaterPrice, double sodaWaterPrice, double waterTankMaxVolume, int bottleCount, string address)
        {
            _stillWaterPrice = stillWaterPrice;
            _sodaWaterPrice = sodaWaterPrice;
            _waterTankMaxVolume = waterTankMaxVolume;
            BottleCount = bottleCount;
            _waterVendingMachine = new WaterVendingMachine(null, null);
            WaterTank = new WaterTank(waterTankMaxVolume);
            Address = address;
        }

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
                    break;
                case Payment.Cash:
                    _paymentStrategy = CashPaymentStrategy;
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
                BottleCount -= _bottleBuyedCount;
                WaterTank.TakeWater(_waterVolume);
                _bottleBuyedCount = 0;
                _waterVolume = 0;
                Income += GetCost();
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
}
