using LABA_2.Task_2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABA_2.Task_2.Interfaces;

namespace LABA_2.Task_2.Classes
{
    public sealed class Cake : Pastry, IShowClasses
    {
        CakeType name = CakeType.Prague;
        string deitaryType = "Не диетический";
        uint procOfSugar = 60;
        int calories = 500;
        PastryType pastryType = PastryType.Cake;
        uint energyValue = 2000;
        decimal price = 500.00M;
        int shelfLife = 2;
        int quality = 100;

        private CakeType Name
        {
            get => name;
            set => name = value;
        }
        public override string DietaryType 
        {
            get => deitaryType;
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && value.Length <= 20)
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
                if (value >= 0 && value <= 10000)
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
                if (value >= 1000 && value <= 30000)
                    energyValue = value;
                else throw new ArgumentException("Введенное значение не входит в диапазон, установлено значение по умолчанию!");
            }
        }
        public override decimal Price
        {
            get => price;
            set
            {
                if (value >= 250.00M && value <= 5000.00M)
                    price = value;
                else throw new ArgumentException("Введенное значение не входит в диапазон, установлено значение по умолчанию!");
            }

        }
        public override int ShelfLife
        {
            get => shelfLife;
            set
            {
                if (value >= 0 && value <= 365)
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

        public Cake() {; }
        public Cake(int name, decimal price, int shelfLife, int quality, string deitaryType, uint procOfSugar, int calories, int pType, uint energyValue) : base(price, shelfLife, quality, deitaryType, procOfSugar, calories, pType, energyValue)
        {
            Name = (CakeType)(name % 6);
        }
        public void ChangePType(int num) => PastryType = (PastryType)(num % 2);
        public override void ChangeName(int num)=> Name = (CakeType)(num % 6);
        public override string ToString() => "\nPastry: \n" + " Name: " + Name + base.ToString();
    }
}


