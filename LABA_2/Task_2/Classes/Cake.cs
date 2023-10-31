using LABA_2.Task_2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_2.Task_2.Classes
{
    public sealed class Cake : Pastry
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

        public CakeType Name
        {
            get => name;
            set => name = value;
        }
        public override string DietaryType 
        {
            get => deitaryType;
            set => deitaryType=value;
        }
        public override uint ProcOfSugar
        {
            get => procOfSugar;
            set=> procOfSugar=value;
        }
        public override int Calories
        {
            get => calories;
            set => calories=value;
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
            set=> price= value;
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

        public Cake() {; }
        public Cake(int name, decimal price, int shelfLife, int quality, string deitaryType, uint procOfSugar, int calories, int pType, uint energyValue) : base(price, shelfLife, quality, deitaryType, procOfSugar, calories, pType, energyValue)
        {
            Name = (CakeType)(name % 6);
        }

        public override void ChangeCalories(int _calories)
        {
            
        }

        public override void ChangeDietaryType(string _dietaryType)
        {
           
        }

        public override void ChangeEnergyValue(uint _energyValue)
        {
            
        }

        public override void ChangePrice(decimal _price)
        {
            
        }

        public override void ChangeProcOfSugar(uint _procOfSugar)
        {
            
        }

        public override void ChangePType(int num)
        {
            
        }

        public override void ChangeQuality(int _quality)
        {
            
        }

        public override void ChangeShelfLife(int _shelfLife)
        {
            
        }
        public override string ToString()
        {
            return "Pastry: \n" + " Name: " + Name + base.ToString();
        }
    }

}
