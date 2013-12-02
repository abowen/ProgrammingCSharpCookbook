using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ReflectionAndMetadata.Instantiate
{
    public class ConstructorInfoCommand : DemoCommand
    {
        public ConstructorInfoCommand()
        {
            AddResource("Reflection and Metadata", "C# in a Nutshell, Chapter 19. Reflection and Metadata");
        }

        public override string Description
        {
            get { return "Constructor Info"; }
        }

        public override void ExecuteDemo()
        {
            var emptyConstructorInfo = typeof(MyHiddenClass).GetConstructor(Type.EmptyTypes);
            emptyConstructorInfo.Invoke(null);

            var int32ConstructorInfo = typeof(MyType).GetConstructor(new[] { typeof(int) });
            int32ConstructorInfo.Invoke(new object[] { 123 });
        }
    }

    public class MyType
    {
        public MyType()
        {
            Console.WriteLine("MyType");
        }

        public MyType(int value)
        {
            Console.WriteLine("MyType {0}", value.GetType());
        }
    }
}
