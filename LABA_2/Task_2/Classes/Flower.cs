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
        public Flower(string name, decimal price, int quality, int color, string wrapper):base(name,price,quality)
        {
            Color = (Color)((color) % 3);
            Wrapper = wrapper;
        }
        public void ChangeColor(int num) => color = (Color)(num % 3);
        public override string ToString() => "\nFlower: \n" + base.ToString() + "\n Color: " + Color + "\n Wrapper: " + Wrapper;
    }
}
