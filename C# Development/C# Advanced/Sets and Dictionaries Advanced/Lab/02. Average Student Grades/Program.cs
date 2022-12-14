using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            var studentGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                var currentStudentInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string studentName = currentStudentInfo[0];
                decimal grade = decimal.Parse(currentStudentInfo[1]);

                if (!studentGrades.ContainsKey(studentName))
                {
                    studentGrades.Add(studentName, new List<decimal>());
                }

                studentGrades[studentName].Add(grade);
            }

            foreach (var (student, grades) in studentGrades)
            {
                Console.Write($"{student} -> ");

                foreach (var grade in grades)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {grades.Average():f2})");
            }
        }
    }
}