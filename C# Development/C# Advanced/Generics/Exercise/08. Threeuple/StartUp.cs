using System;
using System.Linq;

namespace Threeuple
{
    public class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();
            string fullName = string.Join(' ', input.Take(2));
            string address = input[2];
            string town = string.Join(' ', input.Skip(3));
            var threeuple1 = new Threeuple<string, string, string>(fullName, address, town);

            input = Console.ReadLine().Split();
            string drunkName = input[0];
            int litersOfBeer = int.Parse(input[1]);
            bool isDrunk = input[2] == "drunk" ? true : false;
            var threeuple2 = new Threeuple<string, int, bool>(drunkName, litersOfBeer, isDrunk);

            input = Console.ReadLine().Split();
            string name = input[0];
            double balance = double.Parse(input[1]);
            string bankName = input[2];
            var threeuple3 = new Threeuple<string, double, string>(name, balance, bankName);

            Console.WriteLine(threeuple1);
            Console.WriteLine(threeuple2);
            Console.WriteLine(threeuple3);
        }
    }
}
