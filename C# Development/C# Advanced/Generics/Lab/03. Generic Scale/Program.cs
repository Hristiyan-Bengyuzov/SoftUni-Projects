using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> different = new EqualityScale<int>(3, 5);
            Console.WriteLine(different.AreEqual());

            EqualityScale<int> equal = new EqualityScale<int>(3, 3);
            Console.WriteLine(equal.AreEqual());
        }
    }
}
