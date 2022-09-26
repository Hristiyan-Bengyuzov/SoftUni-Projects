using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string kino = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double profit = kino switch
            {
                "Premiere" => 12 * r * c,
                "Normal" => 7.5 * r * c,
                _ => 5 * r * c
            };

            Console.WriteLine($"{profit:f2} leva");
        }
    }
}
