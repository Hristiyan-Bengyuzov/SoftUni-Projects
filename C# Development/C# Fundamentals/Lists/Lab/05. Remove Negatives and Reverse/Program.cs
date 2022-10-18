using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> reversedListWithoutNegatives = Console.ReadLine().Split().Select(int.Parse).ToList();
            reversedListWithoutNegatives.RemoveAll(n => n < 0);
            reversedListWithoutNegatives.Reverse();

            if (!reversedListWithoutNegatives.Any())
            {
                Console.WriteLine("empty");
                return;
            }

            Console.WriteLine(string.Join(" ", reversedListWithoutNegatives));
        }
    }
}
