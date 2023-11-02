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

            //Queue_t<int> p = new();
            //Queue_t<int> q = new();
            //q += 123;
            //q += 1;
            //q += 5;
            //q += 4;
            //q--;
            //if (q)
            //    Console.WriteLine("Тут пусто");
            //else Console.WriteLine("Не пусто");
            //p = p < q;
            //if (p)
            //    Console.WriteLine("Тут пусто");
            //else Console.WriteLine("Не пусто");
            //int i = (int)q;
            //Console.WriteLine(i);
            //q.Print();
            //p.Print();
            //string s = "popachka.c.231";
            //string e = "popachka";
            //string x = ".op";
            //Console.WriteLine("Если в переменной нет точки, то результат возврата -1");
            //int y = s.CheckIndex();
            //int u = e.CheckIndex();
            //int j = x.CheckIndex();
            //Console.WriteLine("s : {0}, e: {1}, x : {2}",y ,u,j);


            //Отловка ошибки
            try {

                Candies candy_try = new Candies(5, 400000.00M, 50, 100, "Светится в темноте!", 50, 2000, 1, 3000);
            }
            catch (ArgumentException ex) {Console.WriteLine(ex.Message); }


            //Создание классов
            Clock clock = new Clock("Apple Watch Series 2", 120000.00M, 80, 2, "4G", "IOS", "4000mAh");
            Cake cake = new Cake();
            Flower flower = new Flower("Роза", 5000.00M, 50, 1, "Блестящая обертка");
            Clock clock_2 = new Clock("Samsung Watches", 65999.99M, 100, 1, "5G", "4G", "Android", "6000mAh");
            Candies candy = new Candies(5, 400.00M, 50, 100, "Светится в темноте!", 50, 200000000, 1, 3000);
            Candies candy_2 = new Candies(1, 800.00M, 100, 56, "Вкусная и сладкая!", 25, 300, 1, 2300);
            Cake cake_2 = new Cake(2, 759.99M, 120, 89, "Вредный до жути!", 100, 800, 2, 4000);

            //Создание класса покупка в котором хранятся приобретенные вещи
            Purchase purchase = new Purchase();

            //Добавление вещей в покупку
            purchase.AddPurchase(clock);
            purchase.AddPurchase(23);
            purchase.AddPurchase(cake);
            purchase.AddPurchase(flower);
            purchase.AddPurchase(candy);
            purchase.AddPurchase("fgsdfgfsdsddfsg");
            purchase.AddPurchase(3421);
            purchase.AddPurchase(clock_2);
            purchase.AddPurchase(cake_2);
            purchase.AddPurchase(candy_2);
            purchase.AddPurchase("dsfsdfd");
            

            
            //Проверка на наличие мусора ( неверно введенных данных ) 
            foreach(var purchaseItem in purchase)
                Console.WriteLine(purchase.Equals(purchaseItem));

            //Удаление ненужных элементов
            purchase.RemoveUnneces();
            //Вывод покупки на консоль
            Console.WriteLine(purchase.ToString());

            //6 задание
            purchase.WarkingTask();

            //Очищение покупки
            purchase.Dispose();
            Console.WriteLine(purchase.ToString());
            



        }
    }
}
