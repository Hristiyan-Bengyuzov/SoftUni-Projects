using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "end")
            {
                string action = commands[0];
                int element = int.Parse(commands[1]);

                switch (action)
                {
                    case "Delete":
                        numbers.RemoveAll(number => number == element);
                        break;
                    case "Insert":
                        int position = int.Parse(commands[2]);
                        numbers.Insert(position, element);
                        break;
                }

                commands = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
