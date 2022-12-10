using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[input[0], input[1]];

            InitializeMatrix(matrix);

            int maximumSquareSum = int.MinValue;
            int maximumRow = 0;
            int maximumCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentSquareSum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];

                    if (currentSquareSum > maximumSquareSum)
                    {
                        maximumSquareSum = currentSquareSum;
                        maximumRow = row;
                        maximumCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[maximumRow, maximumCol]} {matrix[maximumRow, maximumCol + 1]}");
            Console.WriteLine($"{matrix[maximumRow + 1, maximumCol]} {matrix[maximumRow + 1, maximumCol + 1]}");
            Console.WriteLine(maximumSquareSum);
        }

        static void InitializeMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
        }
    }
}