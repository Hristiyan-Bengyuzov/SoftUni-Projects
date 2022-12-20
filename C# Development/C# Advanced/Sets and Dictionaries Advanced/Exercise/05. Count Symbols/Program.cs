using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var charsByOccurences = new Dictionary<char, int>();

            foreach (var character in input)
            {
                if (!charsByOccurences.ContainsKey(character))
                {
                    charsByOccurences.Add(character, 0);
                }

                charsByOccurences[character]++;
            }

            // printing
            foreach (var (character, occurences) in charsByOccurences.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{character}: {occurences} time/s");
            }
        }
    }
}