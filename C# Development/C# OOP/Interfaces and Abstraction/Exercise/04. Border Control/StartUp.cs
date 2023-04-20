using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Identifiable> identifiables = new List<Identifiable>();

            while (true)
            {
                var commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "End") break;

                if (commands.Length == 3) // citizen
                {
                    identifiables.Add(new Citizen(commands[0], int.Parse(commands[1]), commands[2]));
                }
                else if (commands.Length == 2) // robot
                {
                    identifiables.Add(new Robot(commands[0], commands[1]));
                }
            }

            string endValue = Console.ReadLine();
            var fakeIds = identifiables.Where(i => i.IsFake(endValue)).Select(i => i.Id).ToList();

            fakeIds.ForEach(Console.WriteLine);
        }
    }
}