using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            var changes = new Stack<string>();

            StringBuilder text = new StringBuilder();

            for (int i = 0; i < numberOfCommands; i++)
            {
                var commands = Console.ReadLine().Split();

                switch (commands[0])
                {
                    case "1":
                        changes.Push(text.ToString());
                        text.Append(commands[1]);
                        break;
                    case "2":
                        int countToRemove = int.Parse(commands[1]);
                        changes.Push(text.ToString());
                        text.Remove(text.Length - countToRemove, countToRemove);
                        break;
                    case "3":
                        int positionToReturn = int.Parse(commands[1]);
                        Console.WriteLine(text[positionToReturn - 1]);
                        break;
                    case "4":
                        string latestChange = changes.Pop();
                        text.Clear();
                        text.Append(latestChange);
                        break;
                }
            }
        }
    }
}