using System;
using System.ComponentModel;
using System.Threading.Channels;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            OrderPrice(product, quantity);
        }

        private static void OrderPrice(string product, int quantity)
        {
            double productPrice = 0;

            switch (product)
            {
                case "coffee":
                    productPrice = 1.50;
                    break;
                case "water":
                    productPrice = 1;
                    break;
                case "coke":
                    productPrice = 1.40;
                    break;
                case "snacks":
                    productPrice = 2;
                    break;
            }

            double totalPrice = productPrice * quantity;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
