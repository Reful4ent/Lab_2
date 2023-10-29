using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABA_2.Task_2.Enums;

namespace LABA_2.Task_2.Classes
{
    public class Flower : Goods
    {
        string name = "Flower";
        decimal price = 100.0M;
        int quality = 100;
        Color color = Color.Red;
        string wrapper = "Without wrapper";

        public override string Name
        {
            get => name;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    name = value;
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
        public Color Color
        {
            get => color;
            set => color = value;
        }

        public string Wrapper
        {
            get => wrapper;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    wrapper = value;
            }
        }
        
        public Flower() {; }
        public Flower(string name, decimal price, int quality, int color, string wrapper)
        {
            Name = name;
            Price = price;
            Quality = quality;
            Color = (Color)((color) % 3);
            Wrapper = wrapper;
     
        }

        public override void ChangeName(string _name) => Name = String.IsNullOrWhiteSpace(_name) ? "Flower" : _name;
        public override void ChangePrice(decimal _price) => Price = (_price < 100 || _price > 10000) ? 100 : _price;
        public override void ChangeQuality(int _quality) => Quality = (_quality < 0 || _quality > 100) ? 100 : _quality;
        public void ChangeColor(int num) => color = (Color)(num % 3);
        public void ChangeWrapper(string _wrapper) => Wrapper = String.IsNullOrWhiteSpace(_wrapper) ? "Without wrapper" : _wrapper;
        public override string ToString() => "Flower: \n Name: " + Name + "\n Price: " + Price + "\n Quality: " + Quality + "\n Color: " + Color + "\n Wrapper: " + Wrapper;
    }
}
