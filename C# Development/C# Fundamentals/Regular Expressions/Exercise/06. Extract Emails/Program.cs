using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(^|\s)[0-9A-Za-z][\w*\-\.]*[0-9A-Za-z]@[A-Za-z]+([.-][A-Za-z]+)+\b");
            MatchCollection matches = regex.Matches(input);
            Console.WriteLine(string.Join(Environment.NewLine, matches));
        }
    }
}
