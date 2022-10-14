using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int firstNumber = int.Parse(Console.ReadLine());
                    int secondNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstNumber,secondNumber));
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstChar,secondChar));
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    Console.WriteLine(GetMax(firstString,secondString));
                    break;
            }
        }

        static int GetMax(int first, int second) => first > second ? first : second;

        static char GetMax(char first, char second) => first > second ? first : second;

        static string GetMax(string first, string second)
        {
            int result = first.CompareTo(second);
            return result > 0 ? first : second;
        }
    }
}
