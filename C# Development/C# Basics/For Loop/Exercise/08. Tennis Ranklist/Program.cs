using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int beginningPoints = int.Parse(Console.ReadLine());
            int sum = 0;
            int wins = 0;
            for (int i = 0; i < tournaments; i++)
            {
                string stage = Console.ReadLine();
                if (stage == "W")
                {
                    sum += 2000;
                    wins++;
                }
                else if (stage == "F")
                {
                    sum += 1200;
                }
                else
                {
                    sum += 720;
                }
            }

            int finalPoints = sum + beginningPoints;
            double average = (double)sum / tournaments;
            double winProcent = (double)wins / tournaments * 100;

            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(average)}");
            Console.WriteLine($"{winProcent:f2}%");
        }
    }
}
