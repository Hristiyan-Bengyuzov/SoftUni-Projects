using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex healthPattern = new Regex(@"[^0-9+\-*\/.]");
            Regex damagePattern = new Regex(@"[+\-]?\d+\.?\d*");
            Regex multiplicationAndDivisionPattern = new Regex(@"[\*\/]");
            string splitPattern = @"[\s,]+";

            string input = Console.ReadLine();
            string[] demons = Regex.Split(input, splitPattern).OrderBy(x => x).ToArray();

            foreach (var demon in demons)
            {
                MatchCollection healthMatches = healthPattern.Matches(demon);

                int health = 0;
                foreach (Match healthMatch in healthMatches)
                {
                    health += char.Parse(healthMatch.ToString());
                }

                MatchCollection damageMatches = damagePattern.Matches(demon);

                double damage = 0;
                foreach (Match damageMatch in damageMatches)
                {
                    damage += double.Parse(damageMatch.ToString());
                }

                MatchCollection multiplyAndDivideMatches = multiplicationAndDivisionPattern.Matches(demon);

                foreach (Match multiplyAndDivideMatch in multiplyAndDivideMatches)
                {
                    char multiplyOrDivision = char.Parse(multiplyAndDivideMatch.ToString());

                    if (multiplyOrDivision == '*')
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }

                Console.WriteLine($"{demon} - {health} health, {damage:f2} damage");
            }
        }
    }
}