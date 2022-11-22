using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberToMultiply = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            int remainder = 0;

            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = numberToMultiply.Length - 1; i >= 0; i--)
            {
                int numberToMultiplyDigit = int.Parse(numberToMultiply[i].ToString());

                int result = numberToMultiplyDigit * multiplier + remainder;
                sb.Append(result % 10);
                remainder = result / 10;
            }

            if (remainder != 0)
            {
                sb.Append(remainder);
            }

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                Console.Write(sb[i]);
            }
        }
    }
}