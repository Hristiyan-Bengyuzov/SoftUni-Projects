using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] jaggedArray = new double[rows][];

            InitializeJaggedArray(jaggedArray, rows);

            AnalyzeJaggedArray(jaggedArray, rows);

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    // Printing
                    Console.WriteLine(string.Join(Environment.NewLine, jaggedArray.Select(currentRow => string.Join(' ', currentRow))));
                    break;
                }

                var tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (!IsValid(jaggedArray, row, col))
                {
                    continue;
                }

                switch (tokens[0])
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

        static void InitializeJaggedArray(double[][] jaggedArray, int rows)
        {
            for (int row = 0; row < rows; row++)
            {
                var currentRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                jaggedArray[row] = currentRow;
            }
        }

        static void AnalyzeJaggedArray(double[][] jaggedArray, int rows)
        {
            for (int row = 0; row < rows - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    jaggedArray[row] = jaggedArray[row].Select(x => x * 2).ToArray();
                    jaggedArray[row + 1] = jaggedArray[row + 1].Select(x => x * 2).ToArray();
                }
                else
                {
                    jaggedArray[row] = jaggedArray[row].Select(x => x / 2).ToArray();
                    jaggedArray[row + 1] = jaggedArray[row + 1].Select(x => x / 2).ToArray();
                }
            }
        }

        static bool IsValid(double[][] jaggedArray, int row, int col) => row >= 0 && row < jaggedArray.GetLength(0) && col >= 0 && col < jaggedArray[row].Length;
    }
}