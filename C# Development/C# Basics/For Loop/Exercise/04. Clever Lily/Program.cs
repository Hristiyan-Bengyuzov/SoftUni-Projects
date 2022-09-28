using System;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int sum = 0;
            int toyCount = 0;
            int money = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += 10;
                    sum += money - 1;
                }
                else
                {
                    toyCount++;
                }
            }
            sum += toyCount * toyPrice;

            Console.WriteLine(sum >= washingMachinePrice ? $"Yes! {sum - washingMachinePrice:f2}" : $"No! {washingMachinePrice - sum:f2}");
        }
    }
}
