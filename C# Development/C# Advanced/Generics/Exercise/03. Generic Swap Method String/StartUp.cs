using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodString
{
    internal class StartUp
    {
        static void Main()
        {
            List<string> items = new List<string>();
            int numberOfItems = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfItems; i++)
            {
                items.Add(Console.ReadLine());
            }

            int[] indices = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<string> swappedList = Swap(items, indices[0], indices[1]);

            foreach (var item in swappedList)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }

        public static List<T> Swap<T>(List<T> items, int firstIndex, int secondIndex)
        {
            T temp = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = temp;
            return items;
        }
    }
}
