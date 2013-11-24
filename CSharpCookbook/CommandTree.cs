using System;
using System.Collections.Generic;
using CSharpCookbook.Interfaces;

namespace CSharpCookbook
{
    public class CommandTree
    {

        private readonly List<ICommand> _commands = new List<ICommand>();

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach (var command in _commands)
            {
                Console.WriteLine("**************");
                Console.WriteLine(command.Description);
                Console.WriteLine("**************");
                command.Execute();
                Console.WriteLine();
            }
        }
    }
}
