using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._CustomComparator
{
    class Program
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(inputArray, new NumComparer());
            Console.WriteLine(string.Join(" ", inputArray));
        }
    }

    public class NumComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x % 2 == 0 && y % 2 != 0) return -1;
            if (x % 2 != 0 && y % 2 == 0) return 1;
            return x.CompareTo(y);
        }
    }
}
