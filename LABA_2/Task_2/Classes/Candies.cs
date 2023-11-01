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
        public CandyType Name
        {
            get => name;
            set => name = value;
        }
        public override string DietaryType
        {
            get => deitaryType;
            set => deitaryType = value;
        }
        public override uint ProcOfSugar
        {
            get => procOfSugar;
            set => procOfSugar = value;
        }
        public override int Calories
        {
            get => calories;
            set
            {
                if (value == 200000000)
                    Console.WriteLine("Огромное число каллорий, возможно в вашей конфете содержится ИЗОТОП УРАНА-235!!!!!!");
                calories = value;
            }
        }
        public override PastryType PastryType
        {
            get => pastryType;
            set => pastryType = value;
        }
        public override uint EnergyValue
        {
            get => energyValue;
            set => energyValue = value;
        }
        public override decimal Price
        {
            get => price;
            set => price = value;
        }
        public override int ShelfLife
        {
            get => shelfLife;
            set => shelfLife = value;
        }
        public override int Quality
        {
            get => quality;
            set => quality = value;
        }

        public Candies() {; }
        public Candies(int name, decimal price, int shelfLife, int quality, string deitaryType, uint procOfSugar, int calories, int pType, uint energyValue) : base(price, shelfLife, quality, deitaryType, procOfSugar, calories, pType, energyValue)
        {
            Name = (CandyType)(name % 6);
        }

        public override void ChangeCalories(int _calories) => Calories = ((_calories >= 0 && _calories <= 10000)|| _calories==200000000) ? _calories : 1000;
        public override void ChangeDietaryType(string _dietaryType) => DietaryType = (String.IsNullOrWhiteSpace(_dietaryType)) ? "Не диетические" : _dietaryType;
        public override void ChangeEnergyValue(uint _energyValue) => EnergyValue = (_energyValue < 100 || _energyValue > 30000) ? 500 : _energyValue;
        public override void ChangePrice(decimal _price) => Price = (_price < 100.00M || _price > 5000.00M) ? 300.00M : _price;
        public override void ChangeProcOfSugar(uint _procOfSugar) => ProcOfSugar = (_procOfSugar >= 0 && _procOfSugar <= 100) ? _procOfSugar : 75;
        public override void ChangePType(int num) => PastryType = (PastryType)(num % 2);
        public override void ChangeQuality(int _quality) => Quality = (_quality >= 0 && _quality <= 100) ? _quality : 100;
        public override void ChangeShelfLife(int _shelfLife) => ShelfLife = (_shelfLife < 0 || _shelfLife > 730) ? 20 : _shelfLife;
        public override string ToString() => "Pastry: \n" + " Name: " + Name + base.ToString();
    }
}
