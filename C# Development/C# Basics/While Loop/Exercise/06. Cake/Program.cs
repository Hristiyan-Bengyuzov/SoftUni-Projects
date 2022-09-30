using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());
            int cakePieces = cakeWidth * cakeLength;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "STOP")
                {
                    Console.WriteLine($"{cakePieces} pieces are left.");
                    return;
                }

                int currentPiece = int.Parse(command);

                if (cakePieces >= currentPiece) // enough cake
                {
                    cakePieces -= currentPiece;
                }
                else
                {
                    Console.WriteLine($"No more cake left! You need {currentPiece - cakePieces} pieces more.");
                    return;
                }
            }
        }
    }
}
