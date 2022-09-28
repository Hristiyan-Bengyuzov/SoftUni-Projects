using System;

namespace _03._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
            double p4 = 0.0;
            double p5 = 0.0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case < 200:
                        p1++;
                        break;
                    case < 400:
                        p2++;
                        break;
                    case < 600:
                        p3++;
                        break;
                    case < 800:
                        p4++;
                        break;
                    default:
                        p5++;
                        break;
                }
            }

            Console.WriteLine($"{p1 / n * 100:f2}%");
            Console.WriteLine($"{p2 / n * 100:f2}%");
            Console.WriteLine($"{p3 / n * 100:f2}%");
            Console.WriteLine($"{p4 / n * 100:f2}%");
            Console.WriteLine($"{p5 / n * 100:f2}%");
        }
    }
}
