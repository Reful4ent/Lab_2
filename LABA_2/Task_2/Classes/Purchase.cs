using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_2.Task_2.Classes
{
    public class Purchase /*: IEnumerable<object>*/
    {
        List<object> purchaseList=new();
        public Purchase() {; }
        public void AddPurchase(object p) => purchaseList.Add(p);
        //public IEnumerator<object> GetEnumerator()=>purchaseList.GetEnumerator();
        //IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
