using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int failedThreshold = int.Parse(Console.ReadLine());

            int failedCount = 0;
            int problemCount = 0;
            int gradeSum = 0;
            string lastProblem = string.Empty;

            while (true)
            {
                string problem = Console.ReadLine();

                if (problem == "Enough")
                {
                    break;
                }

                int grade = int.Parse(Console.ReadLine());

                if (grade <= 4)
                {
                    failedCount++;
                }

                if (failedCount == failedThreshold)
                {
                    Console.WriteLine($"You need a break, {failedCount} poor grades.");
                    return;
                }

                gradeSum += grade;
                problemCount++;
                lastProblem = problem;
            }

            Console.WriteLine($"Average score: {(double)gradeSum / problemCount:f2}");
            Console.WriteLine($"Number of problems: {problemCount}");
            Console.WriteLine($"Last problem: {lastProblem}");
        }
    }
}
