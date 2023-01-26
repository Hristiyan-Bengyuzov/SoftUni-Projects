using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, Predicate<int>, List<int>> findDivisible = (numbers, isDivisible) => numbers.FindAll(isDivisible);

            int range = int.Parse(Console.ReadLine());
            List<int> numbers = Enumerable.Range(1, range).ToList();
            List<Predicate<int>> predicates = new List<Predicate<int>>();
            List<int> dividers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            foreach (var divider in dividers)
                predicates.Add(p => p % divider == 0);

            foreach (var predicate in predicates)
                numbers = findDivisible(numbers, predicate);

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}