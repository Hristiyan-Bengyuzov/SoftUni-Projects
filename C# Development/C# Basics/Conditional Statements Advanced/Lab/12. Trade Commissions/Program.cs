using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double? quantifier = town switch
            {
                "Sofia" when sales is >= 0 and <= 500 => 0.05,
                "Sofia" when sales is > 500 and <= 1000 => 0.07,
                "Sofia" when sales is > 1000 and <= 10000 => 0.08,
                "Sofia" when sales > 10000 => 0.12,
                "Varna" when sales is >= 0 and <= 500 => 0.045,
                "Varna" when sales is > 500 and <= 1000 => 0.075,
                "Varna" when sales is > 1000 and <= 10000 => 0.1,
                "Varna" when sales > 10000 => 0.13,
                "Plovdiv" when sales is >= 0 and <= 500 => 0.055,
                "Plovdiv" when sales is > 500 and <= 1000 => 0.08,
                "Plovdiv" when sales is > 1000 and <= 10000 => 0.12,
                "Plovdiv" when sales > 10000 => 0.145,
                _ => null
            };

            Console.WriteLine(quantifier.HasValue ? $"{sales * quantifier:f2}" : "error");
        }
    }
}
