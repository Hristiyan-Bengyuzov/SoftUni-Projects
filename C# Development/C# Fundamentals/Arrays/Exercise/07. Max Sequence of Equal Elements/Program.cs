using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 1;
            int biggestCount = int.MinValue;
            int bestNum = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int currentNum = array[i];
                int nextNum = array[i + 1];
                if (currentNum == nextNum)
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count > biggestCount)
                {
                    biggestCount = count;
                    bestNum = currentNum;
                }
            }

            for (int i = 0; i < biggestCount; i++)
            {
                Console.Write($"{bestNum} ");
            }
        }
    }
}
