using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double change = Math.Round(double.Parse(Console.ReadLine()) * 100);
            int coinCounter = 0;

            while (change > 0)
            {
                change -= change switch
                {
                    >= 200 => 200,
                    >= 100 => 100,
                    >= 50 => 50,
                    >= 20 => 20,
                    >= 10 => 10,
                    >= 5 => 5,
                    >= 2 => 2,
                    _ => 1
                };

                coinCounter++;
            }

            Console.WriteLine(coinCounter);
        }
    }
}
