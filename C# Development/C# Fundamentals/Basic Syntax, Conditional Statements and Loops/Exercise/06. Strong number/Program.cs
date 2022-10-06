using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int originalNumber = number;
            int factorialSum = 0;

            while (number != 0)
            {
                int factorialNumber = 1;
                int currentDigit = number % 10;
                number /= 10;

                for (int i = 2; i <= currentDigit; i++)
                {
                    factorialNumber *= i;
                }

                factorialSum += factorialNumber;
            }

            Console.WriteLine(originalNumber == factorialSum ? "yes" : "no");
        }
    }
}
