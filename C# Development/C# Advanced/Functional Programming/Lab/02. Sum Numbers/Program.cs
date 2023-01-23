using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = x => int.Parse(x);
            var arr = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries).Select(parser).ToArray();

            Console.WriteLine(arr.Length);
            Console.WriteLine(arr.Sum());
        }
    }
}