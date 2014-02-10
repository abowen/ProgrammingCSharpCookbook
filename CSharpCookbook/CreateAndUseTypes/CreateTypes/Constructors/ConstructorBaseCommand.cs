using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.CreateTypes.Constructors
{
    public class ConstructorBaseCommand : DemoCommand
    {
        public ConstructorBaseCommand()
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

    public class MyCustomBaseConstructorClass
    {
        public MyCustomBaseConstructorClass(string value)
        {
            Console.WriteLine("MyCustomConstructorClass {0}", value);
        }
    }

    public class MyCustomInheritedConstructorClass : MyCustomBaseConstructorClass
    {
        public MyCustomInheritedConstructorClass(string value)
            : base(value + "test")
        {
            Console.WriteLine("MyCustomInheritedConstructorClass {0}", value);
        }
    }
}
