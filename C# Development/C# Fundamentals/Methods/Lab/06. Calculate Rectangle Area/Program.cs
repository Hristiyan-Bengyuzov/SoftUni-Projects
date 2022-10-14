using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = CalculateRectangleArea(width, height);
            Console.WriteLine(area);
        }

        static double CalculateRectangleArea(double width, double height) => width * height;
    }
}
