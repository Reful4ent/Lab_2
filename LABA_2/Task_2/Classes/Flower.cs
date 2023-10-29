using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_2.Task_2.Classes
{
    public class Flower : Goods
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override decimal Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Quality { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void ChangeName(string _name)
        {
            throw new NotImplementedException();
        }

        public override void ChangePrice(decimal _price)
        {
            throw new NotImplementedException();
        }

        public override void ChangeQuality(int _quality)
        {
            throw new NotImplementedException();
        }
    }
}
