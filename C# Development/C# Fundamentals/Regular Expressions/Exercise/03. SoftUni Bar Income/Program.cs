using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+.?\d+)?\$");

            double totalIncome = 0;

            while (input != "end of shift")
            {
                if (regex.IsMatch(input))
                {
                    string customer = regex.Match(input).Groups["customer"].Value;
                    string product = regex.Match(input).Groups["product"].Value;
                    int count = int.Parse(regex.Match(input).Groups["count"].Value);
                    double price = double.Parse(regex.Match(input).Groups["price"].Value);

                    double currentPrice = count * price;
                    totalIncome += currentPrice;
                    Console.WriteLine($"{customer}: {product} - {currentPrice:f2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}