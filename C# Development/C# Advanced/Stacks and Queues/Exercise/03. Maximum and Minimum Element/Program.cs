using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                var commands = Console.ReadLine().Split();

                switch (commands[0])
                {
                    case "1":
                        stack.Push(int.Parse(commands[1]));
                        break;
                    case "2":
                        if (stack.Any())
                        {
                            stack.Pop();
                        }
                        break;
                    case "3":
                        if (stack.Any())
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case "4":
                        if (stack.Any())
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                }

            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}