using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Alive> alives = new List<Alive>();

            while (true)
            {
                var commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "End") break;
              
                switch (commands[0])
                {
                    case "Citizen": alives.Add(new Citizen(commands[1], int.Parse(commands[2]), commands[3], commands[4])); break;
                    case "Pet": alives.Add(new Pet(commands[1], commands[2])); break;
                }
            }

            string yearToFind = Console.ReadLine();

            var validBirthdates = alives.Where(a => a.Year == yearToFind).Select(a => a.Birthdate).ToList();

            validBirthdates.ForEach(Console.WriteLine);
        }
    }
}
