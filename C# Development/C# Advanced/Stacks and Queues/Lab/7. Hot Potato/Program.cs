using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var players = new Queue<string>(Console.ReadLine().Split());
            int toss = int.Parse(Console.ReadLine());

            while (players.Count > 1)
            {
                for (int i = 1; i < toss; i++)
                {
                    players.Enqueue(players.Dequeue());
                }

                Console.WriteLine($"Removed {players.Dequeue()}");
            }

            Console.WriteLine($"Last is {players.Dequeue()}");
        }
    }
}