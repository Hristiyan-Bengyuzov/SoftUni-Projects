using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());

            double result = Calculate(firstNumber, @operator, secondNumber);
            Console.WriteLine(result);
        }

        static double Calculate(double firstNumber, string @operator, double secondNumber)
        {
            double result = 0;

            switch (@operator)
            {
                case "/":
                    result = firstNumber/secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
            }

            return result;
        }
    }
}
