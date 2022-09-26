using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());
            double shipPrice;
            if (season == "Spring")
            {
                shipPrice = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                shipPrice = 4200;
            }
            else
            {
                shipPrice = 2600;
            }

            if (fishers <= 6)
            {
                shipPrice *= 0.9;
            }
            else if (fishers > 6 && fishers <= 11)
            {
                shipPrice *= 0.85;
            }
            else
            {
                shipPrice *= 0.75;
            }

            if (fishers % 2 == 0 && season != "Autumn")
            {
                shipPrice *= 0.95;
            }

            Console.WriteLine(budget >= shipPrice ? $"Yes! You have {budget - shipPrice:f2} leva left."
                : $"Not enough money! You need {shipPrice - budget:f2} leva.");
        }
    }
}
