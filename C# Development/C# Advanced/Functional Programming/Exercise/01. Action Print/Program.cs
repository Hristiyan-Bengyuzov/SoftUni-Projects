using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            Action<List<string>> printNames = names => names.ForEach(Console.WriteLine);
            printNames(names);
        }
    }
}