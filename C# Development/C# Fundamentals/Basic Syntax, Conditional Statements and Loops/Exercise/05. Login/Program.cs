using System;
using System.Linq;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = new string(username.Reverse().ToArray());
            int counter = 0;
            string input = Console.ReadLine();

            while (input != password)
            {
                counter++;
                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }

                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
            }

            Console.WriteLine($"User {username} logged in.");
        }
    }
}
