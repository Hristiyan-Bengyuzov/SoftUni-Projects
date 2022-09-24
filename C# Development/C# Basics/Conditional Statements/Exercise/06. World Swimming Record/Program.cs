using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordTime = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());
            double swimTime = distance * timeForOneMeter;
            double waterResistanceTime = Math.Truncate(distance / 15) * 12.5;
            double allTime = swimTime + waterResistanceTime;

            Console.WriteLine(allTime < recordTime ? $"Yes, he succeeded! The new world record is {allTime:f2} seconds." : $"No, he failed! He was {allTime - recordTime:f2} seconds slower.");
        }
    }
}
