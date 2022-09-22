using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nailon = int.Parse(Console.ReadLine());
            int boq = int.Parse(Console.ReadLine());
            int razreditel = int.Parse(Console.ReadLine());
            int chasove = int.Parse(Console.ReadLine());
            double nailonSum = (nailon + 2) * 1.5;
            double boqSum = (boq + 0.1 * boq) * 14.5;
            double razreditelSum = razreditel * 5;
            double torbichkiSum = 0.4;
            double allSum = nailonSum + boqSum + razreditelSum + torbichkiSum;
            double maistorSum = (allSum * 0.3) * chasove;
            double finalSum = allSum + maistorSum;
            Console.WriteLine(finalSum);
        }
    }
}
