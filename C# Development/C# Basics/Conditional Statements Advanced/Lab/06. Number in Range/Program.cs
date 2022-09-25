using System;

namespace _06._Number_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            bool inRange = (n >= -100 && n <= 100 && n != 0);
            Console.WriteLine(inRange ? "Yes" : "No");
        }
    }
}
