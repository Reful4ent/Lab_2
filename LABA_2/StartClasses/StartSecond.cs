using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABA_2.Task_2.Classes;
using LABA_2.Task_2.Enums;

namespace LABA_2.StartClasses
{
    public class StartSecond
    {
        public static void Run()
        {
            //Отловка ошибки
            try
            {

                Candies candy_try = new Candies(5, 400000.00M, 50, 100, "Светится в темноте!", 50, 2000, 1, 3000);
            }
            catch (ArgumentException ex) { Console.WriteLine(ex.Message); }

            //Создание класса покупка в котором хранятся приобретенные вещи
            Purchase purchase = new();

            //Добавление вещей в покупку
            purchase.AddPurchase(new Clock(1, 120000.00M, 80, 2, "4G", "IOS", "4000mAh"));
            purchase.AddPurchase(new Cake());
            purchase.AddPurchase(new Flower(5, 5000.00M, 50, 1, "Блестящая обертка"));
            purchase.AddPurchase(new Candies(2, 400.00M, 50, 100, "Светится в темноте!", 50, 200000000, 1, 3000));
            purchase.AddPurchase(new Clock(3, 65999.99M, 100, 1, "5G", "4G", "Android", "6000mAh"));
            purchase.AddPurchase(new Cake(2, 759.99M, 120, 89, "Вредный до жути!", 100, 800, 2, 4000));
            purchase.AddPurchase(new Candies(1, 800.00M, 100, 56, "Вкусная и сладкая!", 25, 300, 1, 2300));

            //Вывод покупки на консоль
            Console.WriteLine(purchase.ToString());

            //6 задание
            Console.WriteLine("\nЗадание №6: ");
            purchase.Current.ChangeName(5);
            Console.WriteLine(purchase.Current.ToString());
            purchase.MoveNext();
            purchase.Current.ChangeName(4);
            Console.WriteLine(purchase.Current.ToString());

            //Equals
            Console.WriteLine("\nПроверка Equals");
            Console.WriteLine(purchase.Equals(purchase.Current));
            purchase.MoveNext();
            Console.WriteLine(purchase.Equals(purchase.Current));
            //GetHashCode
            Console.WriteLine("\nХэш код " + purchase.Index + " элемента списка: " + purchase.GetHashCode());

            //Очищение покупки
            purchase.Dispose();

            //Пустой ли список?
            Console.WriteLine(purchase.ToString());

        }
    }
}
