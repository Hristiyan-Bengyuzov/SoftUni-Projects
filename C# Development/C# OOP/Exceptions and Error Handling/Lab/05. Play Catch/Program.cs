using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Play_Catch
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int exceptionsCount = 0;
            while (exceptionsCount < 3)
            {
                string[] cmd = Console.ReadLine().Split();
                try
                {
                    switch (cmd[0])
                    {
                        case "Replace": Replace(arr, int.Parse(cmd[1]), int.Parse(cmd[2])); break;
                        case "Print": Print(arr, int.Parse(cmd[1]), int.Parse(cmd[2])); break;
                        case "Show": Show(arr, int.Parse(cmd[1])); break;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    exceptionsCount++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    exceptionsCount++;
                }
            }

            Console.WriteLine(string.Join(", ", arr));
        }

        static void Replace(int[] arr, int index, int element) => arr[index] = element;

        static void Print(int[] arr, int start, int end)
        {
            Queue<int> queue = new Queue<int>();

            for (int i = start; i <= end; i++)
            {
                queue.Enqueue(arr[i]);
            }

            Console.WriteLine(string.Join(", ", queue));
        }

        static void Show(int[] arr, int index) => Console.WriteLine(arr[index]);
    }
}