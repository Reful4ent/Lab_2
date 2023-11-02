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
using LABA_2.StartClasses;

namespace LABA_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StartFirst.Run();
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();
            StartSecond.Run();

        }
    }
}
