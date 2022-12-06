using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int[]> queue = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                queue.Enqueue(input);
            }

            int startIndex = 0;

            while (true)
            {
                int totalLiters = 0;
                bool isCompleted = true;

                foreach (int[] item in queue)
                {
                    int liters = item[0];
                    int distance = item[1];

                    totalLiters += liters;

                    if (totalLiters < distance)
                    {
                        startIndex++;
                        int[] currentPump = queue.Dequeue();
                        queue.Enqueue(currentPump);
                        isCompleted = false;
                        break;
                    }

                    totalLiters -= distance;
                }

                if (isCompleted)
                {
                    Console.WriteLine(startIndex);
                    break;
                }
            }
        }
    }
}