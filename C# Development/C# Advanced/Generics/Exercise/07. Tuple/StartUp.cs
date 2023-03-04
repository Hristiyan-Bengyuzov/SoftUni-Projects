using System;
using System.Linq;

namespace Tuple
{
    public class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();
            string fullName = string.Join(' ', input.Take(2));
            string address = input[2];
            var tuple1 = new Tuple<string, string>(fullName, address);

            input = Console.ReadLine().Split();
            string name = input[0];
            int litersOfBeer = int.Parse(input[1]);
            var tuple2 = new Tuple<string, int>(name, litersOfBeer);

            input = Console.ReadLine().Split();
            int integerValue = int.Parse(input[0]);
            double doubleValue = double.Parse(input[1]);
            var tuple3 = new Tuple<int, double>(integerValue, doubleValue);

            Console.WriteLine(tuple1);
            Console.WriteLine(tuple2);
            Console.WriteLine(tuple3);
        }
    }
}
