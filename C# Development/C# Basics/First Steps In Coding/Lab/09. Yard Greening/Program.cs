using System;

namespace _09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m = double.Parse(Console.ReadLine());
            double allPrice = m * 7.61;
            double discount = allPrice * 0.18;
            double finalPrice = allPrice - discount;
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
