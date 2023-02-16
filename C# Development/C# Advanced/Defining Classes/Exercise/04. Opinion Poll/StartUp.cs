using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int countOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfPeople; i++)
            {
                var personInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                people.Add(new Person(personInfo[0], int.Parse(personInfo[1])));
            }

            foreach (var person in people.Where(p => p.Age > 30).OrderBy(p => p.Name))
            {
                Console.WriteLine(person);
            }
        }
    }
}
