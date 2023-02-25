using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] numbers = ArrayCreator.Create(10, 1); // returns 1 10 times
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
