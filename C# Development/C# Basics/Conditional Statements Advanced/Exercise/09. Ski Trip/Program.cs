using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int nights = days - 1;
            string place = Console.ReadLine();
            string review = Console.ReadLine();
            double price;
            if (place == "room for one person")
            {
                price = 18 * nights;
            }
            else if (place == "apartment")
            {
                price = 25 * nights;
                if (nights < 10)
                {
                    price = price - (0.3 * price);
                }
                else if (nights <= 15)
                {
                    price = price - (0.35 * price);
                }
                else
                {
                    price = 0.5 * price;
                }
            }
            else
            {
                price = 35 * nights;
                if (nights < 10)
                {
                    price = price - (0.1 * price);
                }
                else if (nights <= 15)
                {
                    price = price - (0.15 * price);
                }
                else
                {
                    price = price - (0.2 * price);
                }
            }

            price = review == "positive" ? price + (0.25 * price) : price - (0.1 * price);

            Console.WriteLine($"{price:f2}");
        }
    }
}
