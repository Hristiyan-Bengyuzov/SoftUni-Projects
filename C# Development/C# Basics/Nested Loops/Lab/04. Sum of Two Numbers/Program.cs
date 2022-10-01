using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int result = int.Parse(Console.ReadLine());

            int allCombinations = 0;

            for (int i = x; i <= y; i++)
            {
                for (int j = x; j <= y; j++)
                {
                    allCombinations++;
                    if (i + j == result)
                    {
                        Console.WriteLine($"Combination N:{allCombinations} ({i} + {j} = {result})");
                        return;
                    }
                }

            }

            Console.WriteLine($"{allCombinations} combinations - neither equals {result}");
        }
    }
}
