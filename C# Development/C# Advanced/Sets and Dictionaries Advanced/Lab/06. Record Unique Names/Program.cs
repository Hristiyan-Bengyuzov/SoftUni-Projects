using System;
using System.Collections.Generic;

namespace _06._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfNames = int.Parse(Console.ReadLine());
            var uniqueNames = new HashSet<string>();

            for (int i = 0; i < countOfNames; i++)
            {
                string name = Console.ReadLine();
                uniqueNames.Add(name);
            }

            // printing
            foreach (var uniqueName in uniqueNames)
            {
                Console.WriteLine(uniqueName);
            }
        }
    }
}