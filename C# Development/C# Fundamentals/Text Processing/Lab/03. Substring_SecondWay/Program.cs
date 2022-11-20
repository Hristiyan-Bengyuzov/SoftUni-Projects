using System;

namespace _03._Substring_SecondWay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringToRemove = Console.ReadLine();
            string initialString = Console.ReadLine();

            while (initialString.Contains(stringToRemove))
            {
                initialString = initialString.Replace(stringToRemove, string.Empty);
            }

            Console.WriteLine(initialString);
        }
    }
}
