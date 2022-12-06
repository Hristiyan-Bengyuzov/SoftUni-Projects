using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>();

            int numbersToPush = input[0];
            int numbersToPop = input[1];
            int numberToCheck = input[2];

            for (int i = 0; i < numbersToPush; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < numbersToPop; i++)
            {
                stack.Pop();
            }

            if (!stack.Any())
            {
                Console.WriteLine(0);
            }
            else
            {
                if (stack.Contains(numberToCheck))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }
    }
}