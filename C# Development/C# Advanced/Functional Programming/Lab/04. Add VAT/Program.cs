using System;
using System.Linq;

namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, string> addVAT = x => (decimal.Parse(x) * 1.2m).ToString("f2");

            Console.WriteLine(string.Join(Environment.NewLine, Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(addVAT)));
        }
    }
}