using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string firstString = input[0];
            string secondString = input[1];

            int charSum = MultiplyCharacters(firstString, secondString);

            Console.WriteLine(charSum);
        }

        public static int MultiplyCharacters(string firstString, string secondString)
        {
            string longerString = firstString.Length > secondString.Length ? firstString : secondString;
            int max = Math.Max(firstString.Length, secondString.Length);
            int min = Math.Min(firstString.Length, secondString.Length);

            int sum = 0;

            for (int i = 0; i < min; i++)
            {
                sum += firstString[i] * secondString[i];
            }

            for (int i = min; i < max; i++)
            {
                sum += longerString[i];
            }

            return sum;
        }
    }
}