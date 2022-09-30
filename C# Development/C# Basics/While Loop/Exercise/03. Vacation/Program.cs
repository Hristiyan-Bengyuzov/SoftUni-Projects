using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int dayCounter = 0;
            int spendCounter = 0;

            while (true)
            {
                string action = Console.ReadLine();
                double currentMoney = double.Parse(Console.ReadLine());

                dayCounter++;

                if (action == "spend") // spend
                {
                    spendCounter++;
                    availableMoney -= currentMoney;
                    if (availableMoney <= 0)
                    {
                        availableMoney = 0;
                    }
                }
                else // save
                {
                    spendCounter = 0;
                    availableMoney += currentMoney;
                }

                if (spendCounter == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(dayCounter);
                    return;
                }

                if (availableMoney >= neededMoney)
                {
                    Console.WriteLine($"You saved the money for {dayCounter} days.");
                    return;
                }
            }
        }
    }
}
