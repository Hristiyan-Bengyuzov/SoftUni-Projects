using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int preparat = int.Parse(Console.ReadLine());
            double procent = int.Parse(Console.ReadLine());
            procent /= 100;
            double penPrice = pens * 5.80;
            double markerPrice = markers * 7.20;
            double preparatPrice = preparat * 1.20;
            double allPrice = penPrice + markerPrice + preparatPrice;
            double discountPrice = procent * (allPrice);
            double finalPrice = allPrice - discountPrice;
            Console.WriteLine(finalPrice);
        }
    }
}
