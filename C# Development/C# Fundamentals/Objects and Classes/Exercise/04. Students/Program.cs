using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < studentCount; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                Student student = new Student(tokens[0], tokens[1], float.Parse(tokens[2]));
                students.Add(student);
            }

            foreach (Student student in students.OrderByDescending(student=>student.Grade))
            {
                Console.WriteLine(student);
            }
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, float grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Grade { get; set; }

        public override string ToString() => $"{this.FirstName} {this.LastName}: {this.Grade:f2}";

    }
}
