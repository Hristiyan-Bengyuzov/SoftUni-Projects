using System;

namespace _07.Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            bool inRange = (h >= 10 && h <= 18);
            Console.WriteLine(day == "Sunday" || !inRange ? "closed" : "open");
        }
    }
}
