using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "end")
            {
                if (commands[0] == "Add")
                {
                    int newWagon = int.Parse(commands[1]);
                    wagons.Add(newWagon);
                }
                else
                {
                    int passengers = int.Parse(commands[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= maxCapacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }

                commands = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
