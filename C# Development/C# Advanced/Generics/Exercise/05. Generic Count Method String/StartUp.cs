using System;
using System.Collections.Generic;

namespace GenericCountMethodString
{
    internal class StartUp
    {
        static void Main()
        {
            List<Box<string>> boxes = new List<Box<string>>();
            int numberOfEntries = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEntries; i++)
            {
                boxes.Add(new Box<string>(Console.ReadLine()));
            }

            string item = Console.ReadLine();
            Console.WriteLine(Box<string>.GetCountOfLargerElements(boxes, item));
        }
    }
}