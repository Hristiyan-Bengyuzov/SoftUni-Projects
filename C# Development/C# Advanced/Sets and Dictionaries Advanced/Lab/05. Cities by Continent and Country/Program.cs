using System;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            var continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                var currentContinentInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string continent = currentContinentInfo[0];
                string country = currentContinentInfo[1];
                string town = currentContinentInfo[2];

                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country, new List<string>());
                }

                continents[continent][country].Add(town);
            }

            foreach (var (continent, countries) in continents)
            {
                Console.WriteLine($"{continent}: ");

                foreach (var (country, towns) in countries)
                {
                    Console.WriteLine($"  {country} -> {string.Join(", ", towns)}");
                }
            }
        }
    }
}