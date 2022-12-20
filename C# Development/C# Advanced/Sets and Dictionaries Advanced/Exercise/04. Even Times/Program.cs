using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfCommands = int.Parse(Console.ReadLine());
            var numbersEvenTimes = new Dictionary<int, int>();

            for (int i = 0; i < countOfCommands; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!numbersEvenTimes.ContainsKey(number))
                {
                    numbersEvenTimes.Add(number, 0);
                }

                numbersEvenTimes[number]++;
            }

            // printing
            numbersEvenTimes.Where(x => x.Value % 2 == 0).ToList().ForEach(x => Console.WriteLine(x.Key));
        }
    }
}