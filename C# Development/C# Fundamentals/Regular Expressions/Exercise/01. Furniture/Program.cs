using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @">>(?<name>[A-Za-z\s]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";
            List<string> furnitures = new List<string>();

            double totalPrice = 0;

            while (input != "Purchase")
            {
                Match currentMatch = Regex.Match(input, pattern, RegexOptions.IgnoreCase);

                if (currentMatch.Success)
                {
                    string name = currentMatch.Groups["name"].Value;
                    furnitures.Add(name);
                    double price = double.Parse(currentMatch.Groups["price"].Value);
                    int quantity = int.Parse(currentMatch.Groups["quantity"].Value);
                    totalPrice += price * quantity;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            furnitures.ForEach(Console.WriteLine);
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}