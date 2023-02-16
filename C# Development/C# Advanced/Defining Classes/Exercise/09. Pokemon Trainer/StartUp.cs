using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            var trainerCommands = Console.ReadLine().Split();

            while (trainerCommands[0] != "Tournament")
            {
                string trainerName = trainerCommands[0];
                string pokemonName = trainerCommands[1];
                string pokemonElement = trainerCommands[2];
                int pokemonHp = int.Parse(trainerCommands[3]);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer(trainerName));
                }
                trainers[trainerName].Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHp));

                trainerCommands = Console.ReadLine().Split();
            } // adding trainers with pokemons

            while (true)
            {
                string element = Console.ReadLine();

                if (element == "End")
                {
                    break;
                }

                foreach (var trainer in trainers.Values)
                {
                    if (trainer.Pokemons.Any(x => x.Element == element))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        trainer.Pokemons.ForEach(p =>
                        {
                            p.Hp -= 10;
                        });
                        trainer.Pokemons.RemoveAll(p => p.Hp <= 0);
                    }
                }
            } // logic

            foreach (var trainer in trainers.OrderByDescending(x => x.Value.Badges))
            {
                Console.WriteLine(trainer.Value);
            } // printing
        }
    }
}
