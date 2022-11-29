using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>(arr);

            while (true)
            {
                var commands = Console.ReadLine().Split();

                string action = commands[0].ToLower();

                if (action == "end")
                {
                    break;
                }

                if (action == "add")
                {
                    stack.Push(int.Parse(commands[1]));
                    stack.Push(int.Parse(commands[2]));
                }
                else if (action == "remove")
                {
                    int numbersToRemove = int.Parse(commands[1]);

                    if (stack.Count >= numbersToRemove)
                    {
                        for (int i = 0; i < numbersToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}