using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using LABA_2.Task_1;
using LABA_2.Task_2.Classes;
using LABA_2.Task_2.Enums;

namespace LABA_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Queue_t<int> p = new();
            Queue_t<int> q = new();
            q += 123;
            q += 1;
            q += 5;
            q += 4;
            q--;
            if (q)
                Console.WriteLine("Тут пусто");
            else Console.WriteLine("Не пусто");
            p = p < q;
            if (p)
                Console.WriteLine("Тут пусто");
            else Console.WriteLine("Не пусто");
            int i = (int)q;
            Console.WriteLine(i);
            q.Print();
            p.Print();
            string s = "popachka.c.231";
            string e = "popachka";
            string x = ".op";
            Console.WriteLine("Если в переменной нет точки, то результат возврата -1");
            int y = s.CheckIndex();
            int u = e.CheckIndex();
            int j = x.CheckIndex();
            Console.WriteLine("s : {0}, e: {1}, x : {2}",y ,u,j);

            Clock clock= new Clock("ПИДОРАС",12000.00M,50,2,"OLPAKA","TORTIK","POPASIK","ЭССТРАЙХ");
            Console.WriteLine(clock.ToString());
           
        }
    }
}
