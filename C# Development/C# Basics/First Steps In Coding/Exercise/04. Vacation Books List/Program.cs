using System;

namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pageCount = int.Parse(Console.ReadLine());
            int pagePerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int result = (pageCount / pagePerHour) / days;
            Console.WriteLine(result);
        }
    }
}
