using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (isTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool isTopNumber(int number)
        {
            int sum = 0;
            int oddDigitCount = 0;

            while (number > 0)
            {
                int currentDigit = number % 10;

                if (currentDigit % 2 != 0)
                {
                    oddDigitCount++;
                }

                sum += currentDigit;
                number /= 10;
            }

            bool sumDivisibleBy8 = sum % 8 == 0;
            bool atLeastOneOddDigit = oddDigitCount > 0;

            return sumDivisibleBy8 && atLeastOneOddDigit;
        }
    }
}
