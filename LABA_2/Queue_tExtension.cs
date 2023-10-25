using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LABA_2
{
    public static class Queue_tExtension
    {
        public static void Print(this Queue_t<double> q) => Console.WriteLine(q.Items[q.Items.Length - 1]);
        public static void Print(this Queue_t<decimal> q) => Console.WriteLine(q.Items[q.Items.Length - 1]);
        public static void Print(this Queue_t<float> q) => Console.WriteLine(q.Items[q.Items.Length - 1]);
        public static void Print(this Queue_t<string> q) => Console.WriteLine(q.Items[q.Items.Length - 1]);
        public static void Print(this Queue_t<int> q) => Console.WriteLine(q.Items[q.Items.Length - 1]);
        public static void Print(this Queue_t<object> q)=> Console.WriteLine(q.Items[q.Items.Length - 1]);
     
    }
}
