using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> listOfProducts = new Dictionary<string, Product>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "buy")
                {
                    break;
                }

                string name = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);

                if (!listOfProducts.ContainsKey(name))
                {
                    listOfProducts.Add(name, new Product(name, price, quantity));
                }
                else
                {
                    listOfProducts[name].Quantity += quantity;
                    listOfProducts[name].Price = price;
                }
            }

            foreach (var product in listOfProducts)
            {
                Console.WriteLine($"{product.Key} -> {(product.Value.Price * product.Value.Quantity):f2}");
            }
        }
    }

    class Product
    {
        public Product(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }

}


