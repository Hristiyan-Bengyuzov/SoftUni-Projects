using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passingCars = int.Parse(Console.ReadLine());
            var cars = new Queue<string>();

            int totalPassedCars = 0;

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                if (command == "green")
                {
                    for (int i = 0; i < passingCars; i++)
                    {
                        if (cars.Any())
                        {
                            totalPassedCars++;
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }

            }

            Console.WriteLine($"{totalPassedCars} cars passed the crossroads.");
        }
    }
}