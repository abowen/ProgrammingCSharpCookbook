using System;
using System.Linq;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ReflectionAndMetadata.Types
{
    public class NestedCommand : DemoCommand
    {
        public NestedCommand()
        {
            AddResource("Reflection and Metadata", "C# in a Nutshell, Chapter 19. Reflection and Metadata");
        }

        public override string Description
        {
            get { return "Nested Type"; }
        }

        public override void ExecuteDemo()
        {
            var type = typeof (Environment);
            Console.WriteLine("Type: {0}", type.Name);
            var nestedType = type.GetNestedTypes();
            Console.WriteLine(".GetNestedTypes");
            nestedType.ToList().ForEach(Console.WriteLine);
        }
    }
}
