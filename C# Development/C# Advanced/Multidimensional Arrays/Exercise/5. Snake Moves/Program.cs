using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] matrix = new char[dimensions[0], dimensions[1]];
            var snake = new Queue<char>(Console.ReadLine().Trim());

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                FillCurrentRow(matrix, snake, row);
            }

            PrintMatrix(matrix);
        }


        static void FillCurrentRow(char[,] matrix, Queue<char> snake, int row)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                var currentChar = snake.Dequeue();

                if (row % 2 == 0)
                {
                    matrix[row, col] = currentChar;
                }
                else
                {
                    matrix[row, matrix.GetLength(1) - 1 - col] = currentChar;
                }

                snake.Enqueue(currentChar);
            }
        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }

                Console.WriteLine();
            }
        }

    }
}