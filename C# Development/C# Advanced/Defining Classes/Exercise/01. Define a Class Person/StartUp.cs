using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person();
            firstPerson.Name = "Peter";
            firstPerson.Age = 20;

            Person secondPerson = new Person
            {
                Name = "George",
                Age = 18
            };

            Person thirdPerson = new Person("Jose", 43);

            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
            Console.WriteLine(thirdPerson);
        }
    }
}
