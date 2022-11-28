using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            Regex regex = new Regex(@"[^@\-!:>]*\@(?<planet>[A-Z][a-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<type>[AD])![^@\-!:>]*->(?<soldiers>\d+)[^@\-!:>]*");

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string input = Console.ReadLine();

                int count = input.ToLower().Count(x => "star".Contains(x));

                string decryptedMessage = "";
                foreach (var character in input)
                {
                    decryptedMessage += (char)(character - count);
                }

                if (regex.IsMatch(decryptedMessage))
                {
                    string planet = regex.Match(decryptedMessage).Groups["planet"].Value;
                    string type = regex.Match(decryptedMessage).Groups["type"].Value;

                    if (type == "A")
                    {
                        attackedPlanets.Add(planet);
                    }
                    else
                    {
                        destroyedPlanets.Add(planet);
                    }
                }

            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var attackedPlanet in attackedPlanets.OrderBy(planet => planet))
            {
                Console.WriteLine($"-> {attackedPlanet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var destroyedPlanet in destroyedPlanets.OrderBy(planet => planet))
            {
                Console.WriteLine($"-> {destroyedPlanet}");
            }
        }
    }
}
