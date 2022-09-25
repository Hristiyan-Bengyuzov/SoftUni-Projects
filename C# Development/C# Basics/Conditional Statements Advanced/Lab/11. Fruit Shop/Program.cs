using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());

            double? quantifier = null;

            if (day == "Saturday" || day == "Sunday")
            {
                quantifier = fruit switch
                {
                    "banana" => 2.7,
                    "apple" => 1.25,
                    "orange" => 0.9,
                    "grapefruit" => 1.6,
                    "kiwi" => 3,
                    "pineapple" => 5.6,
                    "grapes" => 4.2,
                    _ => null
                };
            }
            else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                quantifier = fruit switch
                {
                    "banana" => 2.5,
                    "apple" => 1.2,
                    "orange" => 0.85,
                    "grapefruit" => 1.45,
                    "kiwi" => 2.7,
                    "pineapple" => 5.5,
                    "grapes" => 3.85,
                    _ => null
                };
            }

            Console.WriteLine(quantifier.HasValue ? $"{count * quantifier:f2}" : "error");
        }
    }
}
