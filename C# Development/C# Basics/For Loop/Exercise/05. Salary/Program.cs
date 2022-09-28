using System;

namespace _05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int openTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            for (int i = 0; i < openTabs; i++)
            {
                string tab = Console.ReadLine();
                salary -= tab switch
                {
                    "Facebook" => 150,
                    "Instagram" => 100,
                    "Reddit" => 50,
                    _ => 0
                };

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }

            Console.WriteLine(salary);
        }
    }
}
