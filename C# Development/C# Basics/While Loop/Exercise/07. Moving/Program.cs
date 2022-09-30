using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int cubicMeters = width * length * height;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Done")
                {
                    Console.WriteLine($"{cubicMeters} Cubic meters left.");
                    return;
                }

                int currentMeters = int.Parse(command);

                if (cubicMeters >= currentMeters) // enough meters
                {
                    cubicMeters -= currentMeters;
                }
                else
                {
                    Console.WriteLine($"No more free space! You need {currentMeters - cubicMeters} Cubic meters more.");
                    return;
                }
            }
        }
    }
}
