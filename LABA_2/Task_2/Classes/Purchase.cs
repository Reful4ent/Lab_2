using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABA_2.Task_2.Interfaces;

namespace LABA_2.Task_2.Classes
{
    public class Purchase : IEnumerable<IShowClasses>, IEnumerator<IShowClasses>
    {
        List<IShowClasses> purchaseList = new();
        int index = 0;
        public int Index { get => index; }
        public void AddPurchase(IShowClasses p) => purchaseList.Add(p);
        //Реализация интерфейсов IEnumerable и IEnumerator
        public IEnumerator<IShowClasses> GetEnumerator() => purchaseList.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        public IShowClasses Current => purchaseList[index];

        object IEnumerator.Current => Current;

        public void Dispose() => purchaseList.Clear();
        public bool MoveNext()
        {
            if(index == purchaseList.Count - 1)
            {
                Reset();
                return false;
            }
            index += 1;
            return true;
        }
        public void Reset() => index = 0;
        //Переопределение методов класса Object
        public override bool Equals(object? obj)
        {
            if(purchaseList.Count<2) return false;
            IShowClasses p = obj as IShowClasses;
            if (p.GetHashCode == purchaseList[1].GetHashCode) return true;
            return false;
        }
        public override int GetHashCode() => purchaseList[index].GetHashCode();

        public override string ToString()
        {
            if (purchaseList.Count == 0) return "\nСписок пуст!";
            string s = null;
            foreach (var p in purchaseList)
                s += p.ToString();
            return "\nPurchase:\n" + s;
        }

    }
}
