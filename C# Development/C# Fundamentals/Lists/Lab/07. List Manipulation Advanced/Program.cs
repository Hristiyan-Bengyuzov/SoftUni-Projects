using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool isChanged = false;

            string[] commands = Console.ReadLine().Split(' ');

            while (commands[0] != "end")
            {
                string action = commands[0];

                switch (action)
                {
                    case "Add":
                        int numberToAdd = int.Parse(commands[1]);
                        numbers.Add(numberToAdd);
                        isChanged = true;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(commands[1]);
                        numbers.Remove(numberToRemove);
                        isChanged = true;
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(commands[1]);
                        numbers.RemoveAt(indexToRemove);
                        isChanged = true;
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(commands[1]);
                        int indexToInsert = int.Parse(commands[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        isChanged = true;
                        break;
                    case "Contains":
                        Console.WriteLine(DoesContain(numbers, int.Parse(commands[1])));
                        break;
                    case "PrintEven":
                        PrintEven(numbers);
                        break;
                    case "PrintOdd":
                        PrintOdd(numbers);
                        break;
                    case "GetSum":
                        Console.WriteLine(GetSum(numbers));
                        break;
                    case "Filter":
                        Filter(numbers, commands[1], int.Parse(commands[2]));
                        break;
                }

                commands = Console.ReadLine().Split(' ');
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        static string DoesContain(List<int> numbers, int number) => numbers.Contains(number) ? "Yes" : "No such number";

        static void PrintEven(List<int> numbers)
        {
            numbers = numbers.Where(number => number % 2 == 0).ToList();
            Console.WriteLine(string.Join(" ", numbers));
        }

        static void PrintOdd(List<int> numbers)
        {
            numbers = numbers.Where(number => number % 2 != 0).ToList();
            Console.WriteLine(string.Join(" ", numbers));
        }

        static int GetSum(List<int> numbers) => numbers.Sum();

        static void Filter(List<int> numbers, string condition, int number)
        {
            switch (condition)
            {
                case "<":
                    numbers = numbers.Where(n => n < number).ToList();
                    break;
                case ">":
                    numbers = numbers.Where(n => n > number).ToList();
                    break;
                case ">=":
                    numbers = numbers.Where(n => n >= number).ToList();
                    break;
                case "<=":
                    numbers = numbers.Where(n => n <= number).ToList();
                    break;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
