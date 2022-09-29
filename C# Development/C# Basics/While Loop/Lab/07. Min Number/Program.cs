using System;

namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int min = int.MaxValue;

            while (input != "Stop")
            {
                int currentNumber = int.Parse(input);
                if (currentNumber < min)
                {
                    min = currentNumber;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(min);
        }
    }
}
