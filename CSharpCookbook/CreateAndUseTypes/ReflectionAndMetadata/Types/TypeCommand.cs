using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ReflectionAndMetadata.Types
{
    public class TypeCommand : DemoCommand
    {
        public TypeCommand()
        {
            AddResource("Reflection and Metadata", "C# in a Nutshell, Chapter 19. Reflection and Metadata");
        }

        public override string Description
        {
            get { return "Type"; }
        }

        public override void ExecuteDemo()
        {
            var stringType = typeof (string);
            Console.WriteLine("Name        : {0}", stringType.Name);
            Console.WriteLine("BaseType    : {0}", stringType.BaseType);
            Console.WriteLine("Assembly    : {0}", stringType.Assembly);
            Console.WriteLine("IsPublic    : {0}", stringType.IsPublic);
            Console.WriteLine("IsPrimitive : {0}", stringType.IsPrimitive);
        }
    }
}
