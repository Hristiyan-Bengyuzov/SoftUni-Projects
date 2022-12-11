using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[dimensions[0], dimensions[1]];

            InitializeMatrix(matrix);

            int maximum3x3SquareSum = int.MinValue;
            int maximumRow = -1;
            int maximumCol = -1;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int current3x3SquareSum = GetCurrent3x3SquareSum(matrix, row, col);
                    if (current3x3SquareSum > maximum3x3SquareSum)
                    {
                        maximum3x3SquareSum = current3x3SquareSum;
                        maximumRow = row;
                        maximumCol = col;
                    }
                }
            }

            PrintSumAndMatrix(matrix, maximum3x3SquareSum, maximumRow, maximumCol);
        }

        static void InitializeMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var colElements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
        }

        static int GetCurrent3x3SquareSum(int[,] matrix, int row, int col)
        {
            int sum = 0;

            for (int currentRow = row; currentRow < row + 3; currentRow++)
            {
                for (int currentCol = col; currentCol < col + 3; currentCol++)
                {
                    sum += matrix[currentRow, currentCol];
                }
            }

            return sum;
        }

        static void PrintSumAndMatrix(int[,] matrix, int maximum3x3SquareSum, int maximumRow, int maximumCol)
        {
            Console.WriteLine($"Sum = {maximum3x3SquareSum}");

            for (int row = maximumRow; row < maximumRow + 3; row++)
            {
                for (int col = maximumCol; col < maximumCol + 3; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}