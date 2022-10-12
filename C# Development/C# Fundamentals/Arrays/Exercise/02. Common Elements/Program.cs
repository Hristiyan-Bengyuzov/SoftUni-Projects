using System;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] arrOne = Console.ReadLine().Split();
            string[] arrTwo = Console.ReadLine().Split();

            foreach (string currElement in arrOne)
            {
                foreach (string secondCurrElement in arrTwo)
                {
                    if (currElement == secondCurrElement)
                    {
                        Console.Write($"{currElement} ");
                        break;
                    }
                }
            }
        }
    }
}
