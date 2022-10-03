using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int currentOddNumber = 2 * i - 1;
                Console.WriteLine(currentOddNumber);
                sum += currentOddNumber;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
