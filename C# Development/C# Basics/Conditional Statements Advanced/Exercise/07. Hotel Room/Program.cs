using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioPrice = 0.0;
            double apartmentPrice = 0.0;
            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50 * nights;
                    apartmentPrice = 65 * nights;
                    if (nights > 14)
                    {
                        studioPrice = studioPrice - (0.3 * studioPrice);
                        apartmentPrice = apartmentPrice - (0.1 * apartmentPrice);
                    }
                    else if (nights > 7)
                    {
                        studioPrice = studioPrice - (0.05 * studioPrice);
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 75.2 * nights;
                    apartmentPrice = 68.7 * nights;
                    if (nights > 14)
                    {
                        studioPrice = studioPrice - (0.2 * studioPrice);
                        apartmentPrice = apartmentPrice - (0.1 * apartmentPrice);
                    }
                    break;
                case "July":
                case "August":
                    studioPrice = 76 * nights;
                    apartmentPrice = 77 * nights;
                    if (nights > 14)
                    {
                        apartmentPrice = apartmentPrice - (0.1 * apartmentPrice);
                    }
                    break;
            }

            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
