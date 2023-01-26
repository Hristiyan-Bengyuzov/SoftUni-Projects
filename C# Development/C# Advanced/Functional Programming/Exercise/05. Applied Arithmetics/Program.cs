using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Action<int[]> add = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                    numbers[i]++;
            };

            Action<int[]> multiply = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                    numbers[i] *= 2;
            };

            Action<int[]> subtract = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                    numbers[i]--;
            };

            Action<int[]> print = numbers => Console.WriteLine(string.Join(' ', numbers));

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                switch (command)
                {
                    case "add": add(numbers); break;
                    case "multiply": multiply(numbers); break;
                    case "subtract": subtract(numbers); break;
                    case "print": print(numbers); break;
                }
            }
        }
    }
}
