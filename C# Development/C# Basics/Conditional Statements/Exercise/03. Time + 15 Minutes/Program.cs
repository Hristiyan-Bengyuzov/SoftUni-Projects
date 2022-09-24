using System;

namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int allTime = h * 60 + m + 15;
            int hour = allTime / 60;
            int minutes = allTime % 60;
            if (hour == 24)
            {
                hour = 0;
            }

            Console.WriteLine(minutes < 10 ? $"{hour}:0{minutes}" : $"{hour}:{minutes}");
        }
    }
}
