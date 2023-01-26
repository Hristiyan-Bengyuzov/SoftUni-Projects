using System;
using System.Linq;

namespace _11._TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int, bool> isNameSumEqualOrLarger = (name, threshold) => name.Sum(ch => ch) >= threshold;
            Func<string[], int, Func<string, int, bool>, string> returnFirstName = (names, threshold, isMatch) => names.FirstOrDefault(name => isMatch(name, threshold));

            int threshold = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Console.WriteLine(returnFirstName(names, threshold, isNameSumEqualOrLarger));
        }

    }
}