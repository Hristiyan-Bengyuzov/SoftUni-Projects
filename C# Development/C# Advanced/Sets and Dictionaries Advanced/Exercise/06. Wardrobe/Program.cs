using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfCommands = int.Parse(Console.ReadLine());
            var clothesByColour = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < countOfCommands; i++)
            {
                var input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string colour = input[0];
                var clothes = input[1].Split(',', StringSplitOptions.RemoveEmptyEntries);

                if (!clothesByColour.ContainsKey(colour))
                {
                    clothesByColour.Add(colour, new Dictionary<string, int>());
                }

                foreach (var currentCloth in clothes)
                {
                    if (!clothesByColour[colour].ContainsKey(currentCloth))
                    {
                        clothesByColour[colour].Add(currentCloth, 0);
                    }

                    clothesByColour[colour][currentCloth]++;
                }
            }

            var toBeFound = Console.ReadLine().Split();
            string colourToBeFound = toBeFound[0];
            string clothToBeFound = toBeFound[1];

            foreach (var (colour, clothes) in clothesByColour)
            {
                Console.WriteLine($"{colour} clothes: ");

                foreach (var (cloth, occurences) in clothes)
                {
                    Console.WriteLine(colour == colourToBeFound && cloth == clothToBeFound ? $"* {cloth} - {occurences} (found!)" :
                        $"* {cloth} - {occurences}");
                }
            }
        }
    }
}