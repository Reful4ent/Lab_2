using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_2.Task_2.Classes
{
    public  class Goods
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quality { get; set; }


        public override string ToString() => "Goods: \n Name:" + Name + " \n Price: " + Price + " \n Quality: " + Quality;
      
    }
}
