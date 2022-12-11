using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            var parentheses = new Stack<char>();
            string input = Console.ReadLine();
            bool isBalanced = true;
            Dictionary<char, char> parDefinitions = new Dictionary<char, char>()
            {
                { '}', '{'},
                {')', '('},
                {']', '['}
            };

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];
                if (parDefinitions.Any(x => x.Value == symbol)) // if it's an opening bracket
                {
                    parentheses.Push(symbol);
                }
                else if (!parentheses.Any() || parDefinitions[symbol] != parentheses.Pop()) // if stack is empty or brackets don't match
                {
                    isBalanced = false;
                    break;
                }
            }

            if (parentheses.Any()) // if there is an unpopped bracket
            {
                isBalanced = false;
            }

            Console.WriteLine(isBalanced ? "YES" : "NO");
        }
    }
}