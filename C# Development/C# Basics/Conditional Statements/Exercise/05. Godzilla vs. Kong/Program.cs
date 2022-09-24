using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statistiCount = int.Parse(Console.ReadLine());
            double clothesPricePerStatist = double.Parse(Console.ReadLine());
            double clothesPrice = statistiCount * clothesPricePerStatist;
            double decorPrice = budget * 0.1;
            if (statistiCount > 150)
            {
                clothesPrice = clothesPrice - (clothesPrice * 0.1);
            }
            double finalPrice = clothesPrice + decorPrice;
            if (finalPrice > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {finalPrice - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - finalPrice:f2} leva left.");
            }
        }
    }
}
