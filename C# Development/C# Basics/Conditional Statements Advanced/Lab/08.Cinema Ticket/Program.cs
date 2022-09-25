using System;

namespace _08.Cinema_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int ticket = day switch
            {
                "Monday" => 12,
                "Tuesday" => 12,
                "Friday" => 12,
                "Wednesday" => 14,
                "Thursday" => 14,
                "Saturday" => 16,
                "Sunday" => 16
            };

            Console.WriteLine(ticket);
        }
    }
}
