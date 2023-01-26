using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._The_Party_Reservation_Filter_Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split().ToList();
            Dictionary<string, Predicate<string>> filters = new Dictionary<string, Predicate<string>>();

            var input = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Print")
            {
                string command = input[0];
                string condition = input[1];
                string value = input[2];

                if (command == "Add filter")
                    filters.Add(condition + value, CreatePredicate(condition, value));
                else
                    filters.Remove(condition + value);

                input = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var filter in filters) // filtering people
                people.RemoveAll(filter.Value);

            Console.WriteLine(string.Join(' ', people));
        }

        static Predicate<string> CreatePredicate(string condition, string value)
        {
            switch (condition)
            {
                case "Starts with": return x => x.StartsWith(value);
                case "Ends with": return x => x.EndsWith(value);
                case "Length": return x => x.Length == int.Parse(value);
                case "Contains": return x => x.Contains(value);
                default: return default(Predicate<string>);
            }
        }
    }
}