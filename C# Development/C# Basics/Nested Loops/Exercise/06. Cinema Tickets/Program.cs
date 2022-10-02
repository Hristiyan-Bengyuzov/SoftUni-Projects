using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();

            int standard = 0;
            int student = 0;
            int kid = 0;
            int occupied = 0;

            while (film != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());
                for (int i = 0; i < freeSeats; i++)
                {
                    string ticket = Console.ReadLine();
                    if (ticket == "End")
                    {
                        break;
                    }
                    else
                    {
                        occupied++;
                        if (ticket == "student")
                        {
                            student++;
                        }
                        else if (ticket == "standard")
                        {
                            standard++;
                        }
                        else
                        {
                            kid++;
                        }
                    }
                }

                Console.WriteLine($"{film} - {100.0 * occupied / freeSeats:f2}% full.");
                occupied = 0;

                film = Console.ReadLine();
            }

            int totalTickets = student + standard + kid;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{100.0 * student / totalTickets:f2}% student tickets.");
            Console.WriteLine($"{100.0 * standard / totalTickets:f2}% standard tickets.");
            Console.WriteLine($"{100.0 * kid / totalTickets:f2}% kids tickets.");
        }
    }
}
