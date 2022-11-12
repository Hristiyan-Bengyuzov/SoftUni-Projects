using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum, rightSum;

            for (int i = 0; i < numbers.Length; i++)
            {
                leftSum = 0;
                for (int sumLeft = i; sumLeft > 0; sumLeft--)
                {
                    leftSum += numbers[sumLeft - 1];
                }

                rightSum = 0;
                for (int sumRight = i; sumRight < numbers.Length - 1; sumRight++)
                {
                    rightSum += numbers[sumRight + 1];
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}