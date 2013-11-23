using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpCookbook
{
    public class CommandTree// : IEnumerable<ICommand>
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

        //public IEnumerator<ICommand> GetEnumerator()
        //{
        //    return _commands.GetEnumerator();
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return GetEnumerator();
        //}
    }
}
