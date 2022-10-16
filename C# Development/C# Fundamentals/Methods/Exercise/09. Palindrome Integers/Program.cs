using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                int number = int.Parse(input);

                Console.WriteLine(isPalindrome(number).ToString().ToLower());

                input = Console.ReadLine();
            }
        }

        static bool isPalindrome(int n)
        {
            int originalValue = n;

            int reversed = 0;

            while (n > 0)
            {
                reversed = reversed * 10 + n % 10;
                n /= 10;
            }

            return originalValue == reversed;
        }
    }
}
