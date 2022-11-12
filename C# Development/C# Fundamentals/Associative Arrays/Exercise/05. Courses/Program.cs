using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> coursesByStudents = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] commands = Console.ReadLine().Split(" : ");
                if (commands[0] == "end")
                {
                    break;
                }

                string course = commands[0];
                string student = commands[1];

                if (!coursesByStudents.ContainsKey(course))
                {
                    coursesByStudents.Add(course, new List<string>());
                }

                coursesByStudents[course].Add(student);
            }

            foreach (var courseByStudents in coursesByStudents)
            {
                Console.WriteLine($"{courseByStudents.Key}: {courseByStudents.Value.Count}");

                foreach (var student in courseByStudents.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
