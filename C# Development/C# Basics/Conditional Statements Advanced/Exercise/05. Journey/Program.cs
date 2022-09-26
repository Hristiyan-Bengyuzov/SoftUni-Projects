using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination;
            string campOrHotel;
            double price;
            if (budget <= 100)
            {
                destination = "Bulgaria";
                price = (season == "summer") ? 0.3 * budget : 0.7 * budget;
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                price = (season == "summer") ? 0.4 * budget : 0.8 * budget;
            }
            else
            {
                destination = "Europe";
                price = 0.9 * budget;
            }

            campOrHotel = (season == "summer") ? "Camp" : "Hotel";
            if (destination == "Europe")
            {
                campOrHotel = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{campOrHotel} - {price:f2}");
        }
    }
}
