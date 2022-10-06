using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice;

            if (group == "Students")
            {
                if (day == "Friday")
                {
                    totalPrice = peopleCount * 8.45;
                }
                else if (day == "Saturday")
                {
                    totalPrice = peopleCount * 9.8;
                }
                else
                {
                    totalPrice = peopleCount * 10.46;
                }

                if (peopleCount >= 30)
                {
                    totalPrice -= totalPrice * 0.15;
                }
            }
            else if (group == "Business")
            {
                if (day == "Friday")
                {
                    totalPrice = peopleCount * 10.9;
                }
                else if (day == "Saturday")
                {
                    totalPrice = peopleCount * 15.6;
                }
                else
                {
                    totalPrice = peopleCount * 16;
                }

                if (peopleCount >= 100)
                {
                    totalPrice -= totalPrice / peopleCount * 10;
                }
            }
            else
            {
                if (day == "Friday")
                {
                    totalPrice = peopleCount * 15;
                }
                else if (day == "Saturday")
                {
                    totalPrice = peopleCount * 20;
                }
                else
                {
                    totalPrice = peopleCount * 22.5;
                }

                if (peopleCount >= 10 && peopleCount <= 20)
                {
                    totalPrice -= totalPrice * 0.05;
                }
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
