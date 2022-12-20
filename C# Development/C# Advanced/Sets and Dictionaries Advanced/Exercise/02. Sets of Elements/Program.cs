using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();
            var intersection = new HashSet<int>();

            for (int i = 0; i < input[0]; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < input[1]; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var first in firstSet)
            {
                foreach (var second in secondSet)
                {
                    if (first == second)
                    {
                        intersection.Add(first);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", intersection));
        }
    }
}
