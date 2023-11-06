using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABA_2.Task_2.Enums;
using LABA_2.Task_2.Interfaces;

namespace LABA_2.Task_2.Classes
{
    public class Flower : Goods, IShowClasses
    {
        FlowerType name = FlowerType.Chrysanthemum; 
        decimal price = 100.0M;
        int quality = 100;
        Color color = Color.Red;
        string wrapper = "Without wrapper";

        private FlowerType Name
        {
            get => name;
            set=> name = value;
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
        private Color Color
        {
            get => color;
            set => color = value;
        }

        public string Wrapper
        {
            get => wrapper;
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && value.Length <= 30)
                    wrapper = value;
                else throw new ArgumentException("Введено пустое название или количество символов превысило максимальное значение, установлено название по умолчанию");
            }
        }
        public Flower() {; }
        public Flower(int name, decimal price, int quality, int color, string wrapper):base(price,quality)
        {
            Name = (FlowerType)(name % 8 );
            Color = (Color)((color) % 3);
            Wrapper = wrapper;
        }
        public void ChangeColor(int num) => color = (Color)(num % 3);
        public override string ToString() => "\nFlower: \n" + " Name: " + Name + base.ToString() + "\n Color: " + Color + "\n Wrapper: " + Wrapper;

        public void ChangeName(int num) => Name = (FlowerType)(num % 8);
    }
}
