using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine(char.IsUpper(ch) ? "upper-case" : "lower-case");
        }
    }
}
