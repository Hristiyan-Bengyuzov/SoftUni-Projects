using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int squareMatrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[squareMatrixSize, squareMatrixSize];

            InitializeSquareMatrix(matrix);

            int firstDiagonal = 0;
            int secondDiagonal = 0;

            for (int row = 0; row < squareMatrixSize; row++)
            {
                firstDiagonal += matrix[row, row];
                secondDiagonal += matrix[row, squareMatrixSize - 1 - row];
            }

            Console.WriteLine(Math.Abs(firstDiagonal - secondDiagonal));
        }

        static void InitializeSquareMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var colElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
        }
    }
}