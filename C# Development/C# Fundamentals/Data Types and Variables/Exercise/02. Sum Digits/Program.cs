using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int finalSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                finalSum += int.Parse(input[i].ToString());
            }

            Console.WriteLine(finalSum);
        }
    }
}
