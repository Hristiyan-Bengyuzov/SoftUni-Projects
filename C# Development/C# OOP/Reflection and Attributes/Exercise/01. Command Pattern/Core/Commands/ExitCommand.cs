using CommandPattern.Core.Contracts;
using System;

namespace CommandPattern.Core.Commands
{
    public class ExitCommand : ICommand
    {
        public string Execute(string[] input)
        {
            Environment.Exit(0);
            return null;
        }
    }
}
