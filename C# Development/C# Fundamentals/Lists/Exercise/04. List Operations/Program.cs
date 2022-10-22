using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] commands = Console.ReadLine().Split();

            while (commands[0]!="End")
            {
                string action = commands[0];

                switch (action)
                {
                    case "Add":
                        int numberToAdd = int.Parse(commands[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(commands[1]);
                        int indexToInsert = int.Parse(commands[2]);
                        if (indexToInsert > numbers.Count - 1 || indexToInsert < 0)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        numbers.Insert(indexToInsert, numberToInsert);
                        break;
                    case "Remove":
                        int indexToRemove = int.Parse(commands[1]);
                        if (indexToRemove > numbers.Count - 1 || indexToRemove < 0)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        numbers.RemoveAt(indexToRemove);
                        break;
                    case "Shift":
                        int count = int.Parse(commands[2]);
                        if (commands[1]=="left")
                        {
                            ShiftLeft(numbers,count);
                        }
                        else
                        {
                            ShiftRight(numbers,count);
                        }
                        break;
                }

                commands = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static void ShiftLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
        }

        static void ShiftRight(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                numbers.Insert(0, numbers[numbers.Count - 1]);
                numbers.RemoveAt(numbers.Count - 1);
            }
        }
    }
}
