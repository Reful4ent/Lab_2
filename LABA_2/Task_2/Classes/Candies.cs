using LABA_2.Task_2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_2.Task_2.Classes
{
    public class Candies : Pastry
    {
        CandyType name = CandyType.Chocolate;
        string deitaryType = "Не диетические";
        uint procOfSugar = 75;
        int calories = 1000;
        PastryType pastryType = PastryType.Candy;
        uint energyValue = 500;
        decimal price = 300.00M;
        int shelfLife = 20;
        int quality = 100;
        private CandyType Name
        {
            get => name;
            set => name = value;
        }
        public override string DietaryType
        {
            get => deitaryType;
            set
            {
                if ((!String.IsNullOrWhiteSpace(value) && value.Length <=20) || value == "Светится в темноте! Огромное число каллорий, возможно в вашей конфете содержится ИЗОТОП УРАНА-235!!!!!!")
                    deitaryType = value;
                else throw new ArgumentException("Введено пустое название или количество символов превысило максимальное значение, установлено название по умолчанию");
            }
        }
        public override uint ProcOfSugar
        {
            get => procOfSugar;
            set
            {
                if (value >= 0 && value <= 100)
                    procOfSugar = value;
                else throw new ArgumentException("Введенное значение не входит в диапазон, установлено значение по умолчанию!");
            }
        }
        public override int Calories
        {
            get => calories;
            set
            {
                if (value == 200000000)
                {
                    DietaryType += (" Огромное число каллорий, возможно в вашей конфете содержится ИЗОТОП УРАНА-235!!!!!!");
                    calories = value;
                }
                else if (value >= 0 && value <= 10000)
                    calories = value;
                else throw new ArgumentException("Введенное значение не входит в диапазон, установлено значение по умолчанию!");



            }
        }
        protected override PastryType PastryType
        {
            get => pastryType;
            set => pastryType = value;
        }
        public override uint EnergyValue
        {
            get => energyValue;
            set
            {
                if (value >= 100 && value <= 30000)
                    energyValue = value;
                else throw new ArgumentException("Введенное значение не входит в диапазон, установлено значение по умолчанию!");
            }
        }
        public override decimal Price
        {
            get => price;
            set
            {
                if (value >= 100.00M && value <= 5000.00M)
                    price = value;
                else throw new ArgumentException("Введенное значение не входит в диапазон, установлено значение по умолчанию!");
            }

        }
        public override int ShelfLife
        {
            get => shelfLife;
            set
            {
                if (value >= 0 && value <= 730)
                    shelfLife = value;
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
        public Candies() {; }
        public Candies(int name, decimal price, int shelfLife, int quality, string deitaryType, uint procOfSugar, int calories, int pType, uint energyValue) : base(price, shelfLife, quality, deitaryType, procOfSugar, calories, pType, energyValue)
        {
            Name = (CandyType)(name % 6);
        }
        public override void ChangeName(int name) => Name = (CandyType)(name % 6);
        public void ChangePType(int num) => PastryType = (PastryType)(num % 2);
        public override string ToString() => "\nPastry: \n" + " Name: " + Name + base.ToString();
    }
}
