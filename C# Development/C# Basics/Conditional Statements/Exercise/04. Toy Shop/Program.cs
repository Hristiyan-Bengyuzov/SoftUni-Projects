using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int dollCount = int.Parse(Console.ReadLine());
            int teddyCount = int.Parse(Console.ReadLine());
            int minionCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());
            double profit = puzzleCount * 2.6 + dollCount * 3 + teddyCount * 4.1 + minionCount * 8.2 + truckCount * 2;
            int toyCount = puzzleCount + dollCount + teddyCount + minionCount + truckCount;
            if (toyCount >= 50)
            {
                profit = profit - (profit * 0.25);
            }
            profit = profit - (profit * 0.1);

            Console.WriteLine(profit >= holidayPrice ? $"Yes! {profit - holidayPrice:f2} lv left." : $"Not enough money! {holidayPrice - profit:f2} lv needed.");
        }
    }
}
