using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customers = new Queue<string>();

            while (true)
            {
                var name = Console.ReadLine();

                if (name == "End")
                {
                    break;
                }

                if (name == "Paid")
                {
                    while (customers.Any())
                    {
                        Console.WriteLine(customers.Dequeue());
                    }
                }
                else
                {
                    customers.Enqueue(name);
                }

            }

            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}