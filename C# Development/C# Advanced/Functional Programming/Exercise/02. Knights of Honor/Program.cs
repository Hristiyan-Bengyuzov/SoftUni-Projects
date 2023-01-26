using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            Action<List<string>> printNames = names => names.ForEach(n => Console.WriteLine($"Sir {n}"));
            printNames(names);
        }
    }
}
