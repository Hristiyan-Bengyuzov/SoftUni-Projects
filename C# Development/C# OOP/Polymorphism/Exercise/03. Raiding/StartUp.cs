using System;
using System.Collections.Generic;
using System.Linq;
using _03.Raiding.Heroes;

namespace _03.Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<BaseHero> heroes = new List<BaseHero>();

            int heroesNeeded = int.Parse(Console.ReadLine());

            while (heroes.Count < heroesNeeded)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                try
                {
                    heroes.Add(HeroFactory.GetHero(name, type));
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            heroes.ForEach(h => Console.WriteLine(h.CastAbility()));

            int bossPower = int.Parse(Console.ReadLine());
            Console.WriteLine(heroes.Sum(h => h.Power) >= bossPower ? "Victory!" : "Defeat...");
        }
    }
}
