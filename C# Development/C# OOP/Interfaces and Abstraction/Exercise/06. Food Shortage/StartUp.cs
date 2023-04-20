using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Buyer> buyers = new Dictionary<string, Buyer>();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (!buyers.ContainsKey(commands[0]))
                {
                    if (commands.Length == 4) // citizen
                    {
                        buyers.Add(commands[0], new Citizen(commands[0], int.Parse(commands[1]), commands[2], commands[3]));
                    }
                    else if (commands.Length == 3) // rebel
                    {
                        buyers.Add(commands[0], new Rebel(commands[0], int.Parse(commands[1]), commands[2]));
                    }
                }
            }

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "End")
                {
                    break;
                }

                if (buyers.ContainsKey(name))
                {
                    buyers[name].BuyFood();
                }
            }

            Console.WriteLine(buyers.Sum(b => b.Value.Food));
        }
    }
}
