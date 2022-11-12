using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfCommands = int.Parse(Console.ReadLine());

            Dictionary<string, string> peopleByPlateNumber = new Dictionary<string, string>();

            for (int i = 0; i < countOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string person = commands[1];

                if (commands[0] == "register")
                {
                    string plateNumber = commands[2];

                    if (peopleByPlateNumber.ContainsKey(person))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                    else
                    {
                        peopleByPlateNumber.Add(person, plateNumber);
                        Console.WriteLine($"{person} registered {plateNumber} successfully");
                    }
                }

                else if (commands[0] == "unregister")
                {
                    if (!peopleByPlateNumber.ContainsKey(person))
                    {
                        Console.WriteLine($"ERROR: user {person} not found");
                    }
                    else
                    {
                        peopleByPlateNumber.Remove(person);
                        Console.WriteLine($"{person} unregistered successfully");
                    }
                }

            }

            foreach (var personByPlateNumber in peopleByPlateNumber)
            {
                Console.WriteLine($"{personByPlateNumber.Key} => {personByPlateNumber.Value}");
            }
        }
    }
}
