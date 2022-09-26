using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string operator1 = Console.ReadLine();
            double result;
            string oddOrEven;

            if (operator1 == "+")
            {
                result = n1 + n2;
                oddOrEven = (result % 2 == 0) ? "even" : "odd";
                Console.WriteLine($"{n1} {operator1} {n2} = {result} - {oddOrEven}");
            }
            else if (operator1 == "-")
            {
                result = n1 - n2;
                oddOrEven = (result % 2 == 0) ? "even" : "odd";
                Console.WriteLine($"{n1} {operator1} {n2} = {result} - {oddOrEven}");
            }
            else if (operator1 == "*")
            {
                result = n1 * n2;
                oddOrEven = (result % 2 == 0) ? "even" : "odd";
                Console.WriteLine($"{n1} {operator1} {n2} = {result} - {oddOrEven}");
            }
            else if (operator1 == "/")
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    result = n1 / n2;
                    Console.WriteLine($"{n1} {operator1} {n2} = {result:f2}");
                }

            }
            else if (operator1 == "%")
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    result = n1 % n2;
                    Console.WriteLine($"{n1} {operator1} {n2} = {result}");
                }

            }
        }
    }
}
