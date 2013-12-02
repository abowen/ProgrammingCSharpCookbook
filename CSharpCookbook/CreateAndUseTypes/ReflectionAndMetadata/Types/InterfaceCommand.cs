using System;
using System.Collections.Generic;
using System.Linq;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ReflectionAndMetadata.Types
{
    public class InterfaceCommand : DemoCommand
    {
        public InterfaceCommand()
        {
            AddResource("Reflection and Metadata", "C# in a Nutshell, Chapter 19. Reflection and Metadata");
        }

        public override string Description
        {
            get { return "Type Interface"; }
        }

        public override void ExecuteDemo()
        {
            var type = typeof (List<int>);
            Console.WriteLine(type);
            Console.WriteLine();
            var interfaces = type.GetInterfaces();
            interfaces.ToList().ForEach(Console.WriteLine);
        }
    }
}
