using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_2.Task_2.Classes
{
    public class Purchase : IEnumerable<object>,IEnumerator<object>
    {
        List<object> purchaseList=new();
        int index = 0;
        public Purchase() {; }

        public void AddPurchase(object p) => purchaseList.Add(p);
        public IEnumerator<object> GetEnumerator() => purchaseList.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        public object Current => purchaseList[index];
        public void Dispose()
        {
            foreach(object p in purchaseList)
                purchaseList.Remove(p);
        }
        public bool MoveNext()
        {
            if(index == purchaseList.Count -1) 
            { 
                Reset();
                return false;
            }
            index+=1;
            return true;
        }
        public void Reset() => index = 0;
        public override int GetHashCode() => index;
        public override string ToString()
        {
            string s = null;
            foreach (object p in purchaseList)
                s += p.ToString();
            return "\nPurchase:" + s;
        }
        public override bool Equals(object? obj)
        {
            
            return (obj is Goods || obj is Product) ? true : false;
        }
    }
}
