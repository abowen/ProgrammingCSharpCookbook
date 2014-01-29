using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ReflectionAndMetadata.Types
{
    public class ArrayCommand : DemoCommand
    {
        public ArrayCommand()
        {
            AddResource("Reflection and Metadata", "C# in a Nutshell, Chapter 19. Reflection and Metadata");
        }

        public override string Description
        {
            get { return "Array Type"; }
        }

        public override void ExecuteDemo()
        {
            ReflectionDemo();            
        }

        private static void ReflectionDemo()
        {
            var stringType = typeof (string);
            Console.WriteLine("typeof(string)     : {0}", stringType.Name);
            var arrayStringType = stringType.MakeArrayType();
            Console.WriteLine(".MakeArrayType()   : {0}", arrayStringType.Name);
            var elementStringType = arrayStringType.GetElementType();
            Console.WriteLine(".GetElementType()  : {0}", elementStringType.Name);
        }
    }
}
