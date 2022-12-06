using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>();

            int numbersToPush = input[0];
            int numbersToPop = input[1];
            int numberToCheck = input[2];

            for (int i = 0; i < numbersToPush; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < numbersToPop; i++)
            {
                queue.Dequeue();
            }

            if (!queue.Any())
            {
                Console.WriteLine(0);
            }
            else
            {
                if (queue.Contains(numberToCheck))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
        }
    }
}
