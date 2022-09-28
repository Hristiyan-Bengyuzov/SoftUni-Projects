using System;

namespace _06._Speed_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            Console.WriteLine(speed switch
            {
                <= 10 => "slow",
                <= 50 => "average",
                <= 150 => "fast",
                <= 1000 => "ultra fast",
                _ => "extremely fast"
            });
        }
    }
}
