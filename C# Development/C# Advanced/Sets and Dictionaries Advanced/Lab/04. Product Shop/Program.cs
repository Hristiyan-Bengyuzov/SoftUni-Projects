using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var productShops = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "Revision")
                {
                    break;
                }

                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!productShops.ContainsKey(shop))
                {
                    productShops.Add(shop, new Dictionary<string, double>());
                }

                productShops[shop].Add(product, price);
            }

            foreach (var (shop, products) in productShops.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{shop}->");

                foreach (var (product, price) in products)
                {
                    Console.WriteLine($"Product: {product}, Price: {price}");
                }
            }
        }
    }
}
