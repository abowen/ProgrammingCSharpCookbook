using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpCookbook
{
    public abstract class Command
    {
        public abstract string Description { get; }
        private readonly List<Command> _childrenCommands = new List<Command>();

        public void AddCommand(Command command)
        {
            _childrenCommands.Add(command);
        }

        public virtual void ExecuteCommand()
        {
            while (true)
            {
                Console.WriteLine("************");
                Console.WriteLine(Description);
                Console.WriteLine("************");
                if (_childrenCommands.Any())
                {
                    Console.WriteLine("0 : Back");
                    for (var index = 0; index < _childrenCommands.Count; index++)
                    {
                        Console.WriteLine("{0} : {1}", index + 1, _childrenCommands[index].Description);
                    }
                }
                else
                {
                    throw new ApplicationException("No valid Commands to display");
                }

                var key = Console.ReadLine();
                var value = -1;
                int.TryParse(key, out value);
                if (value > 0)
                {
                    Console.WriteLine();
                    var command = _childrenCommands[value-1];
                    command.ExecuteCommand();
                }
                else if (value == 0)
                {
                    break;
                }
                else if (value == -1)
                {
                    Console.WriteLine("Invalid input {0}", key);
                }
            }
        }
    }
}
