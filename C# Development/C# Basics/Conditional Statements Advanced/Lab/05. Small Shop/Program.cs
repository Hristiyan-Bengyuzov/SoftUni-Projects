using System;

namespace _05._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());

            double quantifier;

            if (town == "Sofia")
            {
                quantifier = product switch
                {
                    "coffee" => 0.5,
                    "water" => 0.8,
                    "beer" => 1.2,
                    "sweets" => 1.45,
                    _ => 1.6
                };
            }
            else if (town == "Plovdiv")
            {
                quantifier = product switch
                {
                    "coffee" => 0.4,
                    "water" => 0.7,
                    "beer" => 1.15,
                    "sweets" => 1.30,
                    _ => 1.5
                };
            }
            else
            {
                quantifier = product switch
                {
                    "coffee" => 0.45,
                    "water" => 0.7,
                    "beer" => 1.10,
                    "sweets" => 1.35,
                    _ => 1.55
                };
            }

            Console.WriteLine(count * quantifier);
        }
    }
}
