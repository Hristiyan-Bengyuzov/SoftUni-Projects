using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                var currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[row] = currentRow;
            }

            while (true)
            {
                string[] commands = Console.ReadLine().Split();

                if (commands[0] == "END")
                {
                    Console.WriteLine(string.Join(Environment.NewLine, jaggedArray.Select(currentRow => String.Join(" ", currentRow))));
                    break;
                }

                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);

                if (row < 0 || row >= rows || col < 0 || col >= jaggedArray[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                switch (commands[0])
                {
                    case "Add":
                        jaggedArray[row][col] += value;
                        break;
                    case "Subtract":
                        jaggedArray[row][col] -= value;
                        break;
                }
            }
        }
    }
}
