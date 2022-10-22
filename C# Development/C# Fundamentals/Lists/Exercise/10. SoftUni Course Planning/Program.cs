using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> exercises = new List<string>();

            string[] commands = Console.ReadLine().Split(':');

            while (commands[0] != "course start")
            {
                string action = commands[0];
                string lessonTitle = commands[1];

                switch (action)
                {
                    case "Add":
                        AddLesson(lessons, lessonTitle);
                        break;
                    case "Insert":
                        int indexToInsert = int.Parse(commands[2]);
                        InsertLesson(lessons, lessonTitle, indexToInsert);
                        break;
                    case "Remove":
                        RemoveLessonAndExercise(lessons, exercises, lessonTitle);
                        break;
                    case "Swap":
                        string secondLessonTitle = commands[2];
                        Swap(lessons, lessonTitle, secondLessonTitle);
                        break;
                    case "Exercise":
                        Exercise(lessons, exercises, lessonTitle);
                        break;
                }

                commands = Console.ReadLine().Split(':');
            }

            int counter = 1;

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{counter}.{lessons[i]}");
                counter++;

                if (exercises.Contains(lessons[i]))
                {
                    Console.WriteLine($"{counter}.{lessons[i]}-Exercise");
                    counter++;
                }
            }

        }

        static void AddLesson(List<string> lessons, string lessonTitle)
        {
            if (!lessons.Contains(lessonTitle))
            {
                lessons.Add(lessonTitle);
            }
        }

        static void InsertLesson(List<string> lessons, string lessonTitle, int lessonIndex)
        {
            if (lessonIndex >= 0 && lessonIndex < lessons.Count && !lessons.Contains(lessonTitle))
            {
                lessons.Insert(lessonIndex, lessonTitle);
            }
        }

        static void RemoveLessonAndExercise(List<string> lessons, List<string> exercises, string lessonTitle)
        {
            if (lessons.Contains(lessonTitle))
            {
                if (exercises.Contains(lessonTitle))
                {
                    exercises.Remove(lessonTitle);
                }

                lessons.Remove(lessonTitle);
            }
        }

        static void Swap(List<string> lessons, string lessonTitle, string secondLessonTitle)
        {
            int firstLessonIndex = lessons.IndexOf(lessonTitle);
            int secondLessonIndex = lessons.IndexOf(secondLessonTitle);

          
            if (lessons.Contains(lessonTitle) && lessons.Contains(secondLessonTitle))
            {   
                //swap via deconstruction
                (lessons[firstLessonIndex], lessons[secondLessonIndex]) = (lessons[secondLessonIndex], lessons[firstLessonIndex]);
            }
        }

        static void Exercise(List<string> lessons, List<string> exercises, string lessonTitle)
        {
            if (lessons.Contains(lessonTitle) && !exercises.Contains(lessonTitle))
            {
                exercises.Add(lessonTitle);
            }
            else if (!lessons.Contains(lessonTitle))
            {
                lessons.Add(lessonTitle);
                exercises.Add(lessonTitle);
            }
        }

    }
}

