using System;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            foreach (var word in words)
            {
                foreach (var character in word)
                {
                    Console.Write(word);
                }
            }

        }
    }
}
