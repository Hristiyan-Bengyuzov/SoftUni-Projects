using System;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            // print 3 largest
            foreach (var item in arr.OrderByDescending(x => x).Take(3))
            {
                Console.Write($"{item} ");
            }
        }
    }
}