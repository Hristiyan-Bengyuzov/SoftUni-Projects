using System;
using System.Linq;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (!ValidPasswordLength(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!ContainsLetterOrDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!ContainsAtLeastTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (ValidPasswordLength(password) && ContainsLetterOrDigits(password) && ContainsAtLeastTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool ValidPasswordLength(string password) => password.Length >= 6 && password.Length <= 10;

        static bool ContainsLetterOrDigits(string password)
        {
            bool isValid = true;
            foreach (var character in password)
            {
                if (!char.IsLetterOrDigit(character))
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }

        static bool ContainsAtLeastTwoDigits(string password) => password.Count(digit => char.IsDigit(digit)) >= 2;
    }
}
