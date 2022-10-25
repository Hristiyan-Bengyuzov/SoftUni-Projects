using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split();
            List<Student> students = new List<Student>();

            while (commands[0] != "end")
            {
                Student student = students.FirstOrDefault(s => s.FirstName == commands[0] && s.LastName == commands[1]);
                if (student==null)
                {
                    students.Add(new Student(commands[0], commands[1], int.Parse(commands[2]), commands[3]));
                }
                else
                {
                    student.FirstName = commands[0];
                    student.LastName = commands[1];
                    student.Age = int.Parse(commands[2]);
                    student.HomeTown = commands[3];
                }
             
                commands = Console.ReadLine().Split();
            }

            string homeTown = Console.ReadLine();
            List<Student> filteredStudents = students.Where(student => student.HomeTown == homeTown).ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

       
    }

    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}