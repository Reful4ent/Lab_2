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
                if (!String.IsNullOrWhiteSpace(value) && value.Length <= 30)
                    name = value;
                else throw new ArgumentException("Введено пустое название или количество символов превысило максимальное значение, установлено название по умолчанию");
            }
        }
        public override decimal Price
        {
            get => price;
            set
            {
                if (value >= 500 && value <= 500000)
                    price = value;
                else throw new ArgumentException("Введенное значение не входит в диапазон, установлено значение по умолчанию!");
            }
        }
        public override int Quality 
        { 
            get => quality;
            set
            {
                if (value >= 0 && value <= 100) 
                    quality = value;
                else throw new ArgumentException("Введенное значение не входит в диапазон, установлено значение по умолчанию!");
            }
        }

        private ClockType CType 
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
