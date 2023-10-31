using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABA_2.Task_2.Enums;

namespace LABA_2.Task_2.Classes
{
    public abstract class Product
    {
        public abstract decimal Price { get; set; }
        public abstract int ShelfLife { get; set; }
        public abstract int Quality { get; set; }
        public abstract void ChangePrice(decimal _price);
        public abstract void ChangeShelfLife(int _shelfLife);
        public abstract void ChangeQuality(int _quality);
        protected Product() {; }
        protected Product(decimal price, int shelfLife, int quality)
        {
            Price = price;
            ShelfLife = shelfLife;
            Quality = quality;
        }

        public override string ToString() => "\n Price:" + Price + " \n Shelflife: " + ShelfLife + " \n Quality: " + Quality;
    }
}