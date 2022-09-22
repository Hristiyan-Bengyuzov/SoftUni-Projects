using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearTax = int.Parse(Console.ReadLine());
            double kecove = yearTax - (yearTax * 0.4);
            double ekip = kecove - (kecove * 0.2);
            double topka = 1.0 / 4 * ekip;
            double aksesoari = 1.0 / 5 * topka;
            double allPrice = yearTax + kecove + ekip + topka + aksesoari;
            Console.WriteLine(allPrice);
        }
    }
}
