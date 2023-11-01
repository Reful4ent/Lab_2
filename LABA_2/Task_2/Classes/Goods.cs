using System;
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
        protected Goods() {; }
        protected Goods(string name, decimal price, int quality)
        {
            Name = name;
            Price = price;
            Quality = quality;
        }

        public override string ToString() => " Name: " + Name + " \n Price: " + Price + " \n Quality: " + Quality;
       
      
    }
}
