using System;
using System.Linq;

namespace ObjectsAndClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomWord = random.Next(words.Length);
                string currWord = words[i];
                words[i] = words[randomWord];
                words[randomWord] = currWord;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
