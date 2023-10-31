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
        public abstract PastryType PType { get; set; }
        public abstract uint EnergyValue { get; set; }
        public abstract void ChangeDietaryType(string _dietaryType);
        public abstract void ChangeProcOfSugar(uint _procOfSugar);
        public abstract void ChangeCalories(int _calories);
        public abstract void ChangePType(int num);
        public abstract void ChangeEnergyValue(uint _energyValue);
        public override string ToString() => "Pastry type: " + PType + base.ToString() + "\n Dietary type: " + DietaryType + "\n Procent of sugar: " + ProcOfSugar + "\n Calories: " + Calories + "\n Energy value: " + EnergyValue;
        

    }
}
