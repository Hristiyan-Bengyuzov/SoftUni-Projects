using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[,] matrix = new string[dimensions[0], dimensions[1]];

            InitializeMatrix(matrix);

            while (true)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "END")
                {
                    break;
                }

                if (input[0] == "swap" && input.Length == 5)
                {
                    int firstRow = int.Parse(input[1]);
                    int firstCol = int.Parse(input[2]);
                    int secondRow = int.Parse(input[3]);
                    int secondCol = int.Parse(input[4]);
                    Shuffle(matrix, firstRow, firstCol, secondRow, secondCol);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        static void InitializeMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var colElements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
        }

        static bool ValidMatrixInfo(string[,] matrix, int row, int col) => row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);

        static void Shuffle(string[,] matrix, int firstRow, int firstCol, int secondRow, int secondCol)
        {
            if (!ValidMatrixInfo(matrix, firstRow, firstCol) || !ValidMatrixInfo(matrix, secondRow, secondCol))
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            //swap via deconstruction
            (matrix[firstRow, firstCol], matrix[secondRow, secondCol]) = (matrix[secondRow, secondCol], matrix[firstRow, firstCol]);
            PrintMatrix(matrix);
        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
