using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.CreateTypes.Constructors
{
    public class BaseCommand : DemoCommand
    {
        public BaseCommand()
        {
            AddResource("Using Constructors", "http://msdn.microsoft.com/en-us/library/ms173115.aspx");
        }

        public override string Description
        {
            get { return "Base Constructor"; }
        }

        public override void ExecuteDemo()
        {
            var test = new MyCustomInheritedConstructorClass("test");
        }
    }

    public class MyCustomConstructorClass
    {
        public MyCustomConstructorClass(string value)
        {
            Console.WriteLine("MyCustomConstructorClass {0}", value);
        }
    }

    public class MyCustomInheritedConstructorClass : MyCustomConstructorClass
    {
        public MyCustomInheritedConstructorClass(string value)
            : base(value + "test")
        {
            Console.WriteLine("MyCustomInheritedConstructorClass {0}", value);
        }
    }
}
