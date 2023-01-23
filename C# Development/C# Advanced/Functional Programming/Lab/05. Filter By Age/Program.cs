using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < countOfPeople; i++)
            {
                var personInfo = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
                people.Add(new Person(personInfo[0], int.Parse(personInfo[1])));
            }

            string condition = Console.ReadLine();
            int ageThreshold = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            var filter = CreateFilter(condition, ageThreshold);
            var printer = CreatePrinter(format);

            PrintFilteredPeople(people, filter, printer);
        }

        static Func<Person, bool> CreateFilter(string condition, int ageThreshold) => (person) => condition == "older" ? person.Age >= ageThreshold : person.Age < ageThreshold;

        static Action<Person> CreatePrinter(string format) => (person) =>
        {
            switch (format)
            {
                case "name": Console.WriteLine(person.Name); break;
                case "age": Console.WriteLine(person.Age); break;
                case "name age": Console.WriteLine($"{person.Name} - {person.Age}"); break;
                case "age name": Console.WriteLine($"{person.Age} - {person.Name}"); break;
            }
        };

        static void PrintFilteredPeople(List<Person> people, Func<Person, bool> filter, Action<Person> printer) => people.Where(filter).ToList().ForEach(printer);
    }

    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}