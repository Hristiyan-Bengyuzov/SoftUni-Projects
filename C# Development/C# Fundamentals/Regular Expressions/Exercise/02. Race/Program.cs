using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> participants = new Dictionary<string, int>();

            Regex charRegex = new Regex(@"[A-Za-z]");
            Regex digitRegex = new Regex(@"\d+");

            List<string> names = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();

            while (input != "end of race")
            {
                MatchCollection matchedCharacters = charRegex.Matches(input);
                MatchCollection matchedDigits = digitRegex.Matches(input);

                string currName = string.Join("", matchedCharacters);
                string currDigits = string.Join("", matchedDigits);

                int digitSum = 0;
                for (int i = 0; i < currDigits.Length; i++)
                {
                    digitSum += int.Parse(currDigits[i].ToString());
                }

                if (names.Contains(currName))
                {
                    if (!participants.ContainsKey(currName))
                    {
                        participants.Add(currName, digitSum);
                    }
                    else
                    {
                        participants[currName] += digitSum;
                    }
                }

                input = Console.ReadLine();
            }

            int topThreeCount = 1;
            foreach (var winner in participants.OrderByDescending(x => x.Value))
            {
                if (topThreeCount == 1)
                {
                    Console.WriteLine($"1st place: {winner.Key}");
                }
                else if (topThreeCount == 2)
                {
                    Console.WriteLine($"2nd place: {winner.Key}");
                }
                else if (topThreeCount == 3)
                {
                    Console.WriteLine($"3rd place: {winner.Key}");
                    break;
                }
                topThreeCount++;
            }
        }
    }
}