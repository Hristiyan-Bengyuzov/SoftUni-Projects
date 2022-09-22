using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegetarian = int.Parse(Console.ReadLine());
            double deliveryPrice = 2.5;
            double chickenPrice = chicken * 10.35;
            double fishPrice = fish * 12.4;
            double vegetarianPrice = vegetarian * 8.15;
            double allPrice = chickenPrice + fishPrice + vegetarianPrice;
            double dessertPrice = 0.2 * allPrice;
            double finalPrice = allPrice + dessertPrice + deliveryPrice;
            Console.WriteLine(finalPrice);
        }
    }
}
