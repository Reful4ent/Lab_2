using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_2.Task_2.Classes
{
    public class Purchase : IEnumerable<Goods>,IEnumerable<Product>
    {
        List<Goods> goodsList=new();
        List<Product> productList=new();
        public Purchase() {; }
        
        public void AddGoods(Goods p) => goodsList.Add(p);
        public void AddProduct(Product p) => productList.Add(p);
        public IEnumerator<Goods> GetEnumerator() => goodsList.GetEnumerator();
        IEnumerator<Product> IEnumerable<Product>.GetEnumerator()=> productList.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() =>GetEnumerator();

       
    }
}
