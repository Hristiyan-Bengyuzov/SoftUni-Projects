using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wantedBook = Console.ReadLine();
            int checkedBooks = 0;

            while (true)
            {
                string currentBook = Console.ReadLine();

                if (currentBook == "No More Books")
                {
                    break;
                }

                if (currentBook == wantedBook)
                {
                    Console.WriteLine($"You checked {checkedBooks} books and found it.");
                    return;
                }

                checkedBooks++;
            }

            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {checkedBooks} books.");
        }
    }
}
