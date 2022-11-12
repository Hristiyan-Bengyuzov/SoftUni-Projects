using System;
using System.Collections.Generic;

namespace Dictionaries_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charByOccurences = new Dictionary<char, int>();

            string[] words = Console.ReadLine().Split();

            foreach (var word in words)
            {
                foreach (var character in word)
                {
                    if (!charByOccurences.ContainsKey(character))
                    {
                        charByOccurences.Add(character, 0);
                    }

                    charByOccurences[character]++;
                }
            }

            foreach (var item in charByOccurences)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
