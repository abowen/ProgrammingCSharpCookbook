using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpCookbook.BaseCommands
{
    public abstract class DisplayCommand : IMyCommand
    {
        public abstract string Description { get; }
        private readonly List<IMyCommand> _childrenCommands = new List<IMyCommand>();

        public void AddCommand(IMyCommand command)
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

                if (value > _childrenCommands.Count)
                {
                    Console.WriteLine("Out of range {0}", key);
                }
                else if (value > 0)
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

    public interface IMyCommand
    {
        string Description { get; }
        void ExecuteCommand();
    }
}
