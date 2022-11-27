using System;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phoneNumbers = Console.ReadLine();
            string pattern = @"\+359(?<separator>[ \-])2\k<separator>\d{3}\k<separator>\d{4}\b";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(phoneNumbers);

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
