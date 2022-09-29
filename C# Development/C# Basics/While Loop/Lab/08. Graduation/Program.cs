using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 0;
            int counter = 0;
            double sum = 0;

            while (grade < 12)
            {
                double yearlyGrade = double.Parse(Console.ReadLine());
              
                if (yearlyGrade < 4)
                {
                    counter++;
                }

                if (counter > 1)
                {
                    Console.WriteLine($"{name} has been excluded at {grade} grade");
                    return;
                }

                grade++;
                sum += yearlyGrade;
            }

            Console.WriteLine($"{name} graduated. Average grade: {sum / grade:f2}");
        }
    }
}
