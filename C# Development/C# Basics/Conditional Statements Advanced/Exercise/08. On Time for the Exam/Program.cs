using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minuteExam = int.Parse(Console.ReadLine());
            int hourArrival = int.Parse(Console.ReadLine());
            int minuteArrival = int.Parse(Console.ReadLine());
            minuteExam = hourExam * 60 + minuteExam;
            minuteArrival = hourArrival * 60 + minuteArrival;
            int difference = minuteExam - minuteArrival;
            int finalHour = difference / 60;
            int finalMinutes = difference % 60;
            if (difference < 0)
            {
                Console.WriteLine("Late");
                difference = Math.Abs(difference);
                finalHour = Math.Abs(finalHour);
                finalMinutes = Math.Abs(finalMinutes);
                if (difference >= 60)
                {
                    if (finalMinutes < 10)
                    {
                        Console.WriteLine($"{finalHour}:0{finalMinutes} hours after the start");
                    }
                    else
                        Console.WriteLine($"{finalHour}:{finalMinutes} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{finalMinutes} minutes after the start");
                }
            }
            else if (difference <= 30)
            {
                if (difference == 0)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{finalMinutes} minutes before the start");
                }

            }
            else
            {
                Console.WriteLine("Early");
                if (difference >= 60)
                {

                    if (finalMinutes < 10)
                    {
                        Console.WriteLine($"{finalHour}:0{finalMinutes} hours before the start");
                    }
                    else
                        Console.WriteLine($"{finalHour}:{finalMinutes} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{finalMinutes} minutes before the start");
                }
            }
        }
    }
}
