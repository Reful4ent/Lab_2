using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABA_2.Task_2.Enums;

namespace LABA_2.Task_2.Classes
{
    public class Clock : Goods
    {
        string name = "Clock";
        decimal price = 500.0M;
        int quality = 100;
        ClockType clockType = ClockType.Wristwatches;
        List<string> features = new();
        public override string Name 
        {
            get => name;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    name=value;
            }
        }
        public override decimal Price
        {
            get => price;
            set
            {
                if (value >= 500 && value <= 500000)
                    price = value;
            }
        }
        public override int Quality 
        { 
            get => quality;
            set
            {
                if (value >= 0 && value <= 100) 
                    quality = value;
            }
        }

        public ClockType CType 
        {
            get => clockType;
            set => clockType = value;
        }

        public List<string> Features
        {
            get => features;
        }

        public Clock() {; }

        public Clock(string name, decimal price, int quality, int type, params string[] features) : base(name, price, quality)
        {
            CType = (ClockType)((type) % 3);
            ChangeFeatures(features);
        }

        public override void ChangeName(string _name) => Name = String.IsNullOrWhiteSpace(_name) ? "Clock" : _name;
        public override void ChangePrice(decimal _price) => Price = (_price < 500 || _price > 500000) ? 500 : _price;
        public override void ChangeQuality(int _quality) => Quality = (_quality < 0 || _quality > 100) ? 100 : _quality;
        public void ChangeClockType(int num) => clockType = (ClockType)(num % 3);
        public void ChangeFeatures(params string[] feat)
        {
            foreach (var item in feat)
                Features.Add(item);
        }
        public override string ToString()
        {
            string s = null;
            foreach (var item in Features)
                s += item + " ";
            return "\nClock: \n"+ base.ToString() + "\n Type: " + CType + "\n Features: " + s;
        }

    }
}
