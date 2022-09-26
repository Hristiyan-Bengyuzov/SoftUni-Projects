using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price;
            if (flower == "Roses")
            {
                price = 5 * count;
                if (count > 80)
                {
                    price *= 0.9;
                }
            }
            else if (flower == "Dahlias")
            {
                price = 3.8 * count;
                if (count > 90)
                {
                    price *= 0.85;
                }
            }
            else if (flower == "Tulips")
            {
                price = 2.8 * count;
                if (count > 80)
                {
                    price *= 0.85;
                }
            }
            else if (flower == "Narcissus")
            {
                price = 3 * count;
                if (count < 120)
                {
                    price *= 1.15;
                }
            }
            else
            {
                price = 2.5 * count;
                if (count < 80)
                {
                    price *= 1.2;
                }
            }

            Console.WriteLine(budget >= price ? $"Hey, you have a great garden with {count} {flower} and {budget - price:f2} leva left."
                : $"Not enough money, you need {price - budget:f2} leva more.");

        }
    }
}
