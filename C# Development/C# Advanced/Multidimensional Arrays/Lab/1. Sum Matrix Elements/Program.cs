using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ");

            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);

            int[,] matrix = new int[rows, cols];


            // initializing matrix
            for (int row = 0; row < rows; row++)
            {
                var colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            // output
            Console.WriteLine(rows);
            Console.WriteLine(cols);

            int sum = 0;
            foreach (var element in matrix)
            {
                sum += element;
            }

            Console.WriteLine(sum);
        }
    }
}