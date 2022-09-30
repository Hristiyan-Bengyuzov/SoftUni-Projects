using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int GOAL = 10000;
            int sum = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Going home")
                {
                    int finalSteps = int.Parse(Console.ReadLine());
                    sum += finalSteps;

                    if (sum < GOAL)
                    {
                        Console.WriteLine($"{GOAL - sum} more steps to reach goal.");
                    }
                    else
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{sum - GOAL} steps over the goal!");
                    }
                    return;
                }

                int currentSteps = int.Parse(command);
                sum += currentSteps;

                if (sum >= GOAL)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{sum - GOAL} steps over the goal!");
                    return;
                }
            }
        }
    }
}
