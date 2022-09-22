using System;

namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());
            procent /= 100;
            double finalSum = depositSum + n * (depositSum * procent / 12);
            Console.WriteLine(finalSum);
        }
    }
}
