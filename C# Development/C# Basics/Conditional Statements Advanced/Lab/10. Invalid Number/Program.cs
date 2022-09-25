using System;

namespace _10._Invalid_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool valid = (n >= 100 && n <= 200 || n == 0);
            if (!valid)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
