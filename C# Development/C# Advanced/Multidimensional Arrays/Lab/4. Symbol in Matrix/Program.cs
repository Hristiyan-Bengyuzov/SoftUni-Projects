using System;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());

            char[,] matrix = new char[sizeOfMatrix, sizeOfMatrix];

            //Initializing
            for (int row = 0; row < sizeOfMatrix; row++)
            {
                string colElements = Console.ReadLine();

                for (int col = 0; col < sizeOfMatrix; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            char symbolToCheck = char.Parse(Console.ReadLine());
            ContainsSymbol(matrix, symbolToCheck);
        }

        static void ContainsSymbol(char[,] matrix, char symbol)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}