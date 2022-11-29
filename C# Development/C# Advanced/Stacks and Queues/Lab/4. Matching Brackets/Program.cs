using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                var symbol = input[i];

                if (symbol == '(')
                {
                    stack.Push(i);
                }
                else if (symbol == ')')
                {
                    int startIndex = stack.Pop();
                    string result = input.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(result);
                }
            }
        }
    }
}