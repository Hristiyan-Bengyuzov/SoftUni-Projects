using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split().ToList();

            var input = Console.ReadLine().Split();

            while (input[0] != "Party!")
            {
                string command = input[0];
                string condition = input[1];
                string value = input[2];

                if (command == "Remove")
                {
                    people.RemoveAll(CreatePredicate(condition, value));
                }
                else
                {
                    List<string> peopleToDouble = people.FindAll(CreatePredicate(condition, value));
                    int index = people.FindIndex(CreatePredicate(condition, value));

                    if (index != -1) // index validation
                        people.InsertRange(index, peopleToDouble);
                }

                input = Console.ReadLine().Split();
            }

            Console.WriteLine(people.Any() ? $"{string.Join(", ", people)} are going to the party!" : "Nobody is going to the party!");
        }

        static Predicate<string> CreatePredicate(string condition, string value)
        {
            switch (condition)
            {
                case "StartsWith": return x => x.StartsWith(value);
                case "EndsWith": return x => x.EndsWith(value);
                case "Length": return x => x.Length == int.Parse(value);
                default: return default(Predicate<string>);
            }
        }
    }
}