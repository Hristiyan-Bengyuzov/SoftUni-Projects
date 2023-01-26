using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<List<string>, Predicate<string>, List<string>> removeInvalidNames = (names, filter) =>
            {
                names.RemoveAll(filter);
                return names;
            };

            Action<List<string>> print = list => list.ForEach(Console.WriteLine);

            int lengthToFilter = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            names = removeInvalidNames(names, name => name.Length > lengthToFilter);
            print(names);
        }
    }
}
