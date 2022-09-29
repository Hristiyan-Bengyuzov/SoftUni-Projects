using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;

            while (input != "NoMoreMoney")
            {
                double currentNumber = double.Parse(input);

                if (currentNumber < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                sum += currentNumber;
                Console.WriteLine($"Increase: {currentNumber:f2}");

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
