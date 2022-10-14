using System;

namespace _02._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            PrintGradeDefinition(grade);
        }

        static void PrintGradeDefinition(double grade) => Console.WriteLine(grade >= 2.00 && grade < 3 ? "Fail" : grade < 3.50 ? "Poor" : grade < 4.50 ? "Good" : grade < 5.50 ? "Very good" : "Excellent");
    }
}
