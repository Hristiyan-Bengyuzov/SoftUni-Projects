using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int capacity = int.Parse(Console.ReadLine());

            int racks = 1;
            int currentCapacity = capacity;

            while (clothes.Any())
            {
                var currentCloth = clothes.Peek();

                if (currentCapacity >= currentCloth)
                {
                    currentCapacity -= currentCloth;
                    clothes.Pop();
                }
                else
                {
                    racks++;
                    currentCapacity = capacity;
                }
            }

            Console.WriteLine(racks);
        }
    }
}