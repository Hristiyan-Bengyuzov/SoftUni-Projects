using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            double musalaProcent = 0.0;
            double monblanProcent = 0.0;
            double kilimanjaroProcent = 0.0;
            double k2Procent = 0.0;
            double everestProcent = 0.0;
            int allClimbers = 0;
            for (int i = 0; i < groups; i++)
            {
                int climbers = int.Parse(Console.ReadLine());
                allClimbers += climbers;
                if (climbers <= 5)
                {
                    musalaProcent += climbers;
                }
                else if (climbers <= 12)
                {
                    monblanProcent += climbers;
                }
                else if (climbers <= 25)
                {
                    kilimanjaroProcent += climbers;
                }
                else if (climbers <= 40)
                {
                    k2Procent += climbers;
                }
                else
                {
                    everestProcent += climbers;
                }
            }

            Console.WriteLine($"{musalaProcent / allClimbers * 100:f2}%");
            Console.WriteLine($"{monblanProcent / allClimbers * 100:f2}%");
            Console.WriteLine($"{kilimanjaroProcent / allClimbers * 100:f2}%");
            Console.WriteLine($"{k2Procent / allClimbers * 100:f2}%");
            Console.WriteLine($"{everestProcent / allClimbers * 100:f2}%");
        }
    }
}
