using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            int episodeLength = int.Parse(Console.ReadLine());
            int breakLength = int.Parse(Console.ReadLine());
            double lunchTime = 1.0 / 8 * breakLength;
            double otdihTime = 1.0 / 4 * breakLength;
            double remainingTime = breakLength - lunchTime - otdihTime;

            Console.WriteLine(remainingTime >= episodeLength ? $"You have enough time to watch {serial} and left with {Math.Ceiling(remainingTime - episodeLength)} minutes free time."
                : $"You don't have enough time to watch {serial}, you need {Math.Ceiling(episodeLength - remainingTime)} more minutes.");
        }
    }
}
