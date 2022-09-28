using System;

namespace _06._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double actorPoints = double.Parse(Console.ReadLine());
            int judges = int.Parse(Console.ReadLine());
            double points;
            double sum = actorPoints;
            for (int i = 0; i < judges; i++)
            {
                string judge = Console.ReadLine();
                double judgePoints = double.Parse(Console.ReadLine());
                int letterCount = judge.Length;
                points = letterCount * judgePoints / 2;
                sum += points;
                if (sum > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {sum:f1}!");
                    return;
                }
            }

            Console.WriteLine($"Sorry, {actor} you need {1250.5 - sum:f1} more!");
        }
    }
}
