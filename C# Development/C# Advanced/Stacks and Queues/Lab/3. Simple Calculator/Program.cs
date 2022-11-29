using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>(Console.ReadLine().Split().Reverse());

            while (stack.Count > 1)
            {
                int firstNum = int.Parse(stack.Pop());
                string operation = stack.Pop();
                int secondNum = int.Parse(stack.Pop());

                int tempResult = operation switch
                {
                    "+" => firstNum + secondNum,
                    "-" => firstNum - secondNum,
                    _ => 0
                };

                stack.Push(tempResult.ToString());
            }

            Console.WriteLine(stack.Pop());
        }
    }
}