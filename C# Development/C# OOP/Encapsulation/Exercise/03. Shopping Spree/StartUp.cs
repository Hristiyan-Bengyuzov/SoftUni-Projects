using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> people = new Dictionary<string, Person>();
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            var peopleInfo = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var person in peopleInfo)
            {
                try
                {
                    var tokens = person.Split('=', StringSplitOptions.RemoveEmptyEntries);
                    string name = tokens[0];
                    decimal money = decimal.Parse(tokens[1]);
                    people.Add(name, new Person(name, money));
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            var productInfo = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var product in productInfo)
            {
                try
                {
                    var tokens = product.Split('=', StringSplitOptions.RemoveEmptyEntries);
                    string name = tokens[0];
                    decimal cost = decimal.Parse(tokens[1]);
                    products.Add(name, new Product(name, cost));
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            while (true)
            {
                var commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "END")
                {
                    break;
                }

                string person = commands[0];
                string product = commands[1];

                if (people[person].Money >= products[product].Cost) // can afford
                {
                    people[person].Money -= products[product].Cost;
                    people[person].Products.Add(products[product]);
                    Console.WriteLine($"{person} bought {product}");
                }
                else
                {
                    Console.WriteLine($"{person} can't afford {product}");
                }
            }

            foreach (var person in people)
            {
                string boughtProducts = person.Value.Products.Any() ? string.Join(", ", person.Value.Products.Select(p => p.Name)) : "Nothing bought";
                Console.WriteLine($"{person.Key} - {boughtProducts}");
            }
        }
    }
}
