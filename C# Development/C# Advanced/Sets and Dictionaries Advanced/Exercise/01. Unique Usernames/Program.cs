using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfUsernames = int.Parse(Console.ReadLine());
            var uniqueUsernames = new HashSet<string>();

            for (int i = 0; i < countOfUsernames; i++)
            {
                uniqueUsernames.Add(Console.ReadLine());
            }

            // printing
            uniqueUsernames.ToList().ForEach(Console.WriteLine);
        }
    }
}
