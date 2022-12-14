using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var members = new HashSet<string>();

            while (true)
            {
                string memberToAdd = Console.ReadLine();

                if (memberToAdd == "PARTY")
                {
                    break;
                }

                members.Add(memberToAdd);
            }

            while (true)
            {
                string memberToRemove = Console.ReadLine();

                if (memberToRemove == "END")
                {
                    break;
                }

                members.Remove(memberToRemove);
            }

            // printing
            Console.WriteLine(members.Count);
            foreach (var member in members.OrderByDescending(x => StartsWithDigit(x)))
            {
                Console.WriteLine(member);
            }
        }

        static bool StartsWithDigit(string input) => char.IsDigit(input[0]);

    }
}