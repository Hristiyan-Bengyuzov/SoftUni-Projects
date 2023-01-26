using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isOdd = x => x % 2 != 0;
            Predicate<int> isEven = x => x % 2 == 0;
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            List<int> result = new List<int>();

            for (int i = input[0]; i <= input[1]; i++)
                result.Add(i);

            string oddOrEven = Console.ReadLine();
            Console.WriteLine(oddOrEven == "odd" ? string.Join(' ', result.FindAll(isOdd))
                : string.Join(' ', result.FindAll(isEven)));
        }
    }
}
