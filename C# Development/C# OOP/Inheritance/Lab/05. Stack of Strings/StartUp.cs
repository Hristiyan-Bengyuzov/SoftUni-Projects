using System;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings strings = new StackOfStrings();

            strings.AddRange(new string[] { "1", "2", "3", "4" });

            while (!strings.IsEmpty())
            {
                Console.WriteLine(strings.Pop());
            }
        }
    }
}
