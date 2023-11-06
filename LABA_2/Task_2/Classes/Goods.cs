using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABA_2.Task_2.Interfaces;

namespace LABA_2.Task_2.Classes
{
    public abstract class Goods 
    {
        public abstract decimal Price { get; set; }
        public abstract int Quality { get; set; }
        protected Goods() {; }
        protected Goods(decimal price, int quality)
        {
            Price = price;
            Quality = quality;
        }

        public override string ToString() =>" \n Price: " + Price + " \n Quality: " + Quality;
       
      
    }
}
