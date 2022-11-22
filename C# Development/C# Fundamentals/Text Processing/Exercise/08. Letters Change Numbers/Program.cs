using System;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach (var word in input)
            {
                char firstLetter = word[0];
                char lastLetter = word[word.Length - 1];
                double number = double.Parse(word.Substring(1, word.Length - 2));

                int firstLetterAlphabetPosition = char.IsUpper(firstLetter) ? firstLetter - 64 : firstLetter - 96;
                int lastLetterAlphabetPosition = char.IsUpper(lastLetter) ? lastLetter - 64 : lastLetter - 96;

                if (char.IsUpper(firstLetter)) //operations with first letter
                {
                    number /= firstLetterAlphabetPosition;
                }
                else
                {
                    number *= firstLetterAlphabetPosition;
                }

                if (char.IsUpper(lastLetter)) //operations with last letter
                {
                    number -= lastLetterAlphabetPosition;
                }
                else
                {
                    number += lastLetterAlphabetPosition;
                }

                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}