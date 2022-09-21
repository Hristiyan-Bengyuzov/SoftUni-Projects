using System;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dog = int.Parse(Console.ReadLine());
            int cat = int.Parse(Console.ReadLine());
            double dogPrice = dog * 2.5;
            double catPrice = cat * 4;
            double result = dogPrice + catPrice;
            Console.WriteLine($"{result} lv.");
        }
    }
}
