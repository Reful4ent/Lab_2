﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_2.Task_2.Classes
{
    public abstract class Goods
    {
        public abstract string Name { get; set; }
        public abstract decimal Price { get; set; }
        public abstract int Quality { get; set; }
        public override string ToString() => "Goods: \n Name:" + Name + " \n Price: " + Price + " \n Quality: " + Quality;
        public abstract void ChangeName(string _name);
        public abstract void ChangePrice(decimal _price);
        public abstract void ChangeQuality(int _quality);
      
    }
}