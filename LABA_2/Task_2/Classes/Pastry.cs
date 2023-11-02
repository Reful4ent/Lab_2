using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABA_2.Task_2.Enums;

namespace LABA_2.Task_2.Classes
{
    public abstract class Pastry : Product
    {


        public abstract string DietaryType { get; set; }
        public abstract uint ProcOfSugar { get; set; }
        public abstract int Calories { get; set; }
        protected abstract PastryType PastryType { get; set; }
        public abstract uint EnergyValue { get; set; }
        protected Pastry() {; }
        protected Pastry(decimal price, int shelfLife, int quality, string dietaryType, uint procOfSugar, int calories, int pType, uint energyValue) : base(price, shelfLife, quality)
        {
            DietaryType = dietaryType;
            ProcOfSugar = procOfSugar;
            Calories = calories;
            PastryType = (PastryType)(pType % 2);
            EnergyValue = energyValue;
        }
        public abstract void ChangeName(int name);
        public override string ToString() => "\n Pastry type: " + PastryType + base.ToString() + "\n Dietary type: " + DietaryType + "\n Procent of sugar: " + ProcOfSugar + "\n Calories: " + Calories + "\n Energy value: " + EnergyValue;
        

    }
}
