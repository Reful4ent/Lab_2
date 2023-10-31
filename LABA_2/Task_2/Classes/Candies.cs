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
        public CandyType CandyType { get; set; }
        public override string DietaryType { get; set; }
        public override uint ProcOfSugar { get; set; }
        public override int Calories { get; set; }
        public override PastryType PastryType { get; set; }
        public override uint EnergyValue { get; set; }
        public override decimal Price { get; set; }
        public override int ShelfLife { get; set; }
        public override int Quality { get; set; }

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
    }
}
