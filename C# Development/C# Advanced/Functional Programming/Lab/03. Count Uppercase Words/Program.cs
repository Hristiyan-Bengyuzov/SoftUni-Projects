using System;

namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> startsWithUpper = word => char.IsUpper(word[0]);

            Console.WriteLine(string.Join(Environment.NewLine,
                Array.FindAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), startsWithUpper)));
        }
    }
}