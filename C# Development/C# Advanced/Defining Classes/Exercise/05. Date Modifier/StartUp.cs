using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            DateModifier dateModifier = new DateModifier();
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            Console.WriteLine(dateModifier.SubtractDates(first, second));
        }
    }
}
