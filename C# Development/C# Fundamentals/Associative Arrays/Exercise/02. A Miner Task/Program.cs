using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourcesByQuantity = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }

                string quantity = Console.ReadLine();

                if (quantity == "stop")
                {
                    break;
                }

                int quantityOfResource = int.Parse(quantity);

                if (!resourcesByQuantity.ContainsKey(resource))
                {
                    resourcesByQuantity.Add(resource, 0);
                }

                resourcesByQuantity[resource] += quantityOfResource;
            }

            foreach (var resourceByQuantity in resourcesByQuantity)
            {
                Console.WriteLine($"{resourceByQuantity.Key} -> {resourceByQuantity.Value}");
            }
        }
    }
}
