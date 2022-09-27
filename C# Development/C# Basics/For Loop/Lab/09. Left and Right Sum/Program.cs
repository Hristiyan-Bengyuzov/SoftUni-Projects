using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                int leftNumbers = int.Parse(Console.ReadLine());
                leftSum += leftNumbers;
            }

            for (int i = 0; i < n; i++)
            {
                int rightNumbers = int.Parse(Console.ReadLine());
                rightSum += rightNumbers;
            }

            Console.WriteLine(leftSum == rightSum ? $"Yes, sum = {leftSum}" : $"No, diff = { Math.Abs(leftSum - rightSum)}");
        }
    }
}
