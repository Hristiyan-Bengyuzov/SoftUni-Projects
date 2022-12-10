using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = ParseArrayFromConsole(',', ' ');

            int[,] matrix = new int[input[0], input[1]];

            InitializeMatrix(matrix);

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int currentColSum = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    currentColSum += matrix[row, col];
                }

                Console.WriteLine(currentColSum);
            }
        }

        static void InitializeMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var colElements = ParseArrayFromConsole(' ');

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
        }

        static int[] ParseArrayFromConsole(params char[] splitSymbols) => Console.ReadLine().Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    }
}
