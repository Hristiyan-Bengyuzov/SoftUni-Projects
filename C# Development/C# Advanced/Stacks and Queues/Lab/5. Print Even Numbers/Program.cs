using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>();

            // LINQ alternative:
            // var queue = new Queue<int>(input.Where(x => x % 2 == 0));

            foreach (var item in input)
            {
                if (item % 2 == 0)
                {
                    queue.Enqueue(item);
                }
            }

            Console.WriteLine(string.Join(", ", queue));
        }
    }
}
