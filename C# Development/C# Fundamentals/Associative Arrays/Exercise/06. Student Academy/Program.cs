using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentsByGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsByGrades.ContainsKey(student))
                {
                    studentsByGrades.Add(student, new List<double>());
                }

                studentsByGrades[student].Add(grade);
            }

            foreach (var student in studentsByGrades.Where(student => student.Value.Average() >= 4.50))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }
        }
    }
}
