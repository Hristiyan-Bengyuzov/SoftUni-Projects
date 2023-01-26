using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, List<int>> reverse = list =>
            {
                List<int> reversedList = new List<int>();
                for (int i = list.Count - 1; i >= 0; i--)
                    reversedList.Add(list[i]);

                return reversedList;
            };

            Func<List<int>, Predicate<int>, List<int>> excludeDivisible = (numbers, isDivisible) =>
            {
                numbers.RemoveAll(isDivisible);
                return numbers;
            };

            var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int divisor = int.Parse(Console.ReadLine());

            numbers = reverse(numbers);
            numbers = excludeDivisible(numbers, x => x % divisor == 0);

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}