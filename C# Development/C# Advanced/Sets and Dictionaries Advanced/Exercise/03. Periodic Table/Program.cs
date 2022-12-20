using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfCommands = int.Parse(Console.ReadLine());
            var uniqueChemicalElements = new HashSet<string>();

            for (int i = 0; i < countOfCommands; i++)
            {
                var currentChemicalElements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                currentChemicalElements.ForEach(e => uniqueChemicalElements.Add(e));
            }

            // printing
            uniqueChemicalElements.OrderBy(e => e).ToList().ForEach(e => Console.Write($"{e} "));
        }
    }
}