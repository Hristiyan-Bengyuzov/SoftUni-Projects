using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int countOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfPeople; i++)
            {
                var personInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                family.AddMember(new Person(personInfo[0], int.Parse(personInfo[1])));
            }

            Console.WriteLine(family.GetOldestMember());
        }
    }
}
