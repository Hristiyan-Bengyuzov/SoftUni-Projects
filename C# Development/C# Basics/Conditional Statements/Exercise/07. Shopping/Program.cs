using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());
            double videoCardPrice = N * 250;
            double cpuPrice = M * (0.35 * videoCardPrice);
            double ramPrice = P * (0.1 * videoCardPrice);
            double allPrice = videoCardPrice + cpuPrice + ramPrice;
            if (N > M)
            {
                allPrice = allPrice - (0.15 * allPrice);
            }

            Console.WriteLine(budget >= allPrice ? $"You have {budget - allPrice:f2} leva left!" : $"Not enough money! You need {allPrice - budget:f2} leva more!");
        }
    }
}
