using System;

namespace _07.KnightGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            InitializeMatrix(matrix);

            int knightsRemoved = 0;

            while (true)
            {
                int countMostAttacking = 0;
                int rowMostAttacking = 0;
                int colMostAttacking = 0;

                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            int attackedKnights = CountAttackedKnights(row, col, matrix);

                            if (attackedKnights < countMostAttacking)
                            {
                                countMostAttacking = attackedKnights;
                                rowMostAttacking = row;
                                colMostAttacking = col;
                            }
                        }
                    }
                }

                if (countMostAttacking == 0)
                {
                    break;
                }
                else
                {
                    matrix[rowMostAttacking, colMostAttacking] = '0';
                    knightsRemoved++;
                }
            }

            Console.WriteLine(knightsRemoved);
        }

        private static void InitializeMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string chars = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = chars[col];
                }
            }
        }

        static int CountAttackedKnights(int row, int col, char[,] matrix)
        {
            int attackedKnights = 0;

            //horizontal left-up
            if (ThereIsAnotherKnightHere(matrix, row - 1, col - 2)) attackedKnights++;

            //horizontal left-down
            if (ThereIsAnotherKnightHere(matrix, row + 1, col - 2)) attackedKnights++;

            //horizontal right-up
            if (ThereIsAnotherKnightHere(matrix, row - 1, col + 2)) attackedKnights++;

            //horizontal right-down
            if (ThereIsAnotherKnightHere(matrix, row + 1, col + 2)) attackedKnights++;

            //vertical up-left
            if (ThereIsAnotherKnightHere(matrix, row - 2, col - 1)) attackedKnights++;

            //vertical up-right
            if (ThereIsAnotherKnightHere(matrix, row - 2, col + 1)) attackedKnights++;

            //vertical down-left
            if (ThereIsAnotherKnightHere(matrix, row + 2, col - 1)) attackedKnights++;

            //vertical down-right
            if (ThereIsAnotherKnightHere(matrix, row + 2, col + 1)) attackedKnights++;

            return attackedKnights;
        }

        static bool ThereIsAnotherKnightHere(char[,] matrix, int row, int col) => row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1) && (matrix[row, col] == 'K');
    }
}