using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var numbersByOccurences = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!numbersByOccurences.ContainsKey(number))
                {
                    numbersByOccurences.Add(number, 0);
                }

                numbersByOccurences[number]++;
            }

            foreach (var (number, occurences) in numbersByOccurences)
            {
                Console.WriteLine($"{number} - {occurences} times");
            }
        }
    }
}