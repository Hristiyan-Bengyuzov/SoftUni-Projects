using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());
            procent /= 100;
            double volume = length * width * height;
            double volumeInLitres = volume * 0.001;
            double neededLitres = volumeInLitres - (volumeInLitres * procent);
            Console.WriteLine(neededLitres);
        }
    }
}
