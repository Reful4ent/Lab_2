using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_2.Task_1
{
    public class Queue_t<T>
    {
        T[] items = { };
        public T[] Items { get { return items; } }
        public Queue_t() {; }

        public void Resize(ref T[] items, int newSize)
        {
            T[] newItems = new T[newSize];
            for (int i = 0; i < items.Length && i < newItems.Length; i++)
                newItems[i] = items[i];
            items = newItems;
        }
        public void AntiResize(ref T[] items, int newSize)
        {
            T[] newItems = new T[newSize];
            for (int i = 1; i < items.Length; i++)
                newItems[i - 1] = items[i];
            items = newItems;
        }

        public static Queue_t<T> operator +(Queue_t<T> q, T item)
        {
            Queue_t<T> temp = new Queue_t<T>();
            q.Resize(ref q.items, q.items.Length + 1);
            q.items[q.items.Length - 1] = item;
            temp.items = q.items;
            return temp;
        }
        public static Queue_t<T> operator --(Queue_t<T> q)
        {
            Queue_t<T> temp = new Queue_t<T>();
            q.AntiResize(ref q.items, q.items.Length - 1);
            temp.items = q.items;
            return temp;
        }
        public static bool operator true(Queue_t<T> q) => q.items.Length == 0;
        public static bool operator false(Queue_t<T> q) => q.items.Length != 0;

        public static Queue_t<T> operator <(Queue_t<T> q, Queue_t<T> p)
        {
            Queue_t<T> temp = new Queue_t<T>();
            temp.Resize(ref temp.items, p.items.Length);
            Array.Copy(p.items, temp.items, p.items.Length);
            Array.Sort(temp.items);
            Array.Reverse(temp.items);
            return temp;
        }
        public static Queue_t<T> operator >(Queue_t<T> q, Queue_t<T> p)
        {
            Queue_t<T> temp = new Queue_t<T>();
            temp.items = q.items;

            return temp;
        }
        public static implicit operator int(Queue_t<T> q) => q.items.Length;

    }
}
