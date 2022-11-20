using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringToRemove = Console.ReadLine();
            string initialString = Console.ReadLine();

            while (initialString.Contains(stringToRemove))
            {
                int index = initialString.IndexOf(stringToRemove);
                initialString = initialString.Remove(index, stringToRemove.Length);
            }

            Console.WriteLine(initialString);
        }
    }
}
