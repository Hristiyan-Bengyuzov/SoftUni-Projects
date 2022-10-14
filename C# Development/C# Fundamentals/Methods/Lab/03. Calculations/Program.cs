using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case "add":
                    Console.WriteLine(Sum(number1,number2));
                    break;
                case "subtract":
                    Console.WriteLine(Subtract(number1,number2));
                    break;
                case "multiply":
                    Console.WriteLine(Multiply(number1,number2));
                    break;
                case "divide":
                    Console.WriteLine(Divide(number1,number2));
                    break;
            }
        }

        static int Sum(int number1, int number2) => number1 + number2;

        static  int Subtract(int number1, int number2) => number1 - number2;

        static int Divide(int number1, int number2) => number1 / number2;

        static int Multiply(int number1, int number2) => number1 * number2;
    }
}
