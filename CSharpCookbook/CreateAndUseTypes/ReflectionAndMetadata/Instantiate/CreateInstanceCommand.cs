using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ReflectionAndMetadata.Instantiate
{
    public class CreateInstanceCommand : DemoCommand
    {
        public CreateInstanceCommand()
        {
            AddResource("Reflection and Metadata", "C# in a Nutshell, Chapter 19. Reflection and Metadata");
        }

        public override string Description
        {
            get { return "Create Instance"; }
        }

        public override void ExecuteDemo()
        {
            var value = (int) Activator.CreateInstance(typeof (int));            
            value = 123;
            Console.WriteLine("{0} : {1}", value.GetType(), value);
            var constructorValue = (DateTime) Activator.CreateInstance(typeof (DateTime), 2010, 10, 30);
            Console.WriteLine("{0} : {1}", constructorValue.GetType(), constructorValue);
        }
    }
}
