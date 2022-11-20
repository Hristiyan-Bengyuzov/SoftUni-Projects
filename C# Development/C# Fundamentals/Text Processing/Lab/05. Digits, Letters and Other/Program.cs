using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder other = new StringBuilder();

            foreach (var character in input)
            {
                if (char.IsDigit(character))
                {
                    digits.Append(character);
                }
                else if (char.IsLetter(character))
                {
                    letters.Append(character);
                }
                else
                {
                    other.Append(character);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}
