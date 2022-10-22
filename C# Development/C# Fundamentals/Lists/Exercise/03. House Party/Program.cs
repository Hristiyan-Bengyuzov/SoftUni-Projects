using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> people = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] currentPersonInfo = Console.ReadLine().Split();
                string person = currentPersonInfo[0];

                if (currentPersonInfo[2] == "going!") //going
                {
                    if (!people.Contains(person))
                    {
                        people.Add(person);
                    }
                    else
                    {
                        Console.WriteLine($"{person} is already in the list!");
                    }

                }
                else //not going
                {
                    if (people.Contains(person))
                    {
                        people.Remove(person);
                    }
                    else
                    {
                        Console.WriteLine($"{person} is not in the list!");
                    }

                }
            }

            Console.WriteLine(string.Join(Environment.NewLine,people));
        }
    }
}
