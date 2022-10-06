using System;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(age switch
            {
                <= 2 => "baby",
                <= 13 => "child",
                <= 19 => "teenager",
                <= 65 => "adult",
                _ => "elder"
            });
        }
    }
}
