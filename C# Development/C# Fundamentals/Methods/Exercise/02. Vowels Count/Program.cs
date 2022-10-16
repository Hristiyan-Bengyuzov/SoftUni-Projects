using System;
using System.Linq;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();

            int vowelCount = VowelCount(text);
            Console.WriteLine(vowelCount);
        }

        static int VowelCount(string text) => text.Count(vowel => "aeiou".Contains(vowel));
    }
}
