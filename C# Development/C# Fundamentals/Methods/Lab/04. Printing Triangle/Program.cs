using System;

namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }

        static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintLine(1, i);
            }

            for (int i = n - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }
    }
}
