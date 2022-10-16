using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine(Min(number1, Min(number2, number3)));
        }

        static int Min(int number1, int number2) => number1 < number2 ? number1 : number2;
    }
}
