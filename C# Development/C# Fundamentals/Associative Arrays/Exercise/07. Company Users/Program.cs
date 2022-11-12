using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companiesByEmployees = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] commands = Console.ReadLine().Split(" -> ");
                if (commands[0]=="End")
                {
                    break;
                }

                string company = commands[0];
                string id = commands[1];

                if (!companiesByEmployees.ContainsKey(company))
                {
                    companiesByEmployees.Add(company, new List<string>());
                }

                if (!companiesByEmployees[company].Contains(id))
                {
                    companiesByEmployees[company].Add(id);
                }
            }

            foreach (var companyByEmployees in companiesByEmployees)
            {
                Console.WriteLine($"{companyByEmployees.Key}");
                foreach (var id in companyByEmployees.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
