using System;

namespace _05._Number_100_200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (x < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (x >= 100 && x <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
                Console.WriteLine("Greater than 200");
        }
    }
}
