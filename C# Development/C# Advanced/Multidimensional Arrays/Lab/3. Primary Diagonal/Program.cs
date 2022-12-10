using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];

            InitializeMatrix(matrix);

            int primaryDiagonalSum = 0;

            for (int row = 0; row < sizeOfMatrix; row++)
            {
                primaryDiagonalSum += matrix[row, row];
            }

            Console.WriteLine(primaryDiagonalSum);
        }

        static void InitializeMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var colElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[col, row] = colElements[col];
                }
            }
        }
    }
}