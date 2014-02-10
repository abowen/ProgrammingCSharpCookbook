using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.CreateTypes.Constructors
{
    public class ConstructorPrivateCommand : DemoCommand
    {
        public ConstructorPrivateCommand()
        {
            AddResource("Private Constructors", "http://msdn.microsoft.com/en-us/library/kcfb85a6%28v=vs.120%29.aspx");
        }

        public override string Description
        {
            get { return "Private Constructor"; }
        }

        public override void ExecuteDemo()
        {
            var works = new MyCustomHideConstructorClass("test");
            //var fails = new MyCustomHideConstructorClass(); // throws compile error
        }
    }

    public class MyCustomHideConstructorClass
    {        
        public MyCustomHideConstructorClass(string value)
        {
            Console.WriteLine("MyCustomHideConstructorClass {0}", value);
        }
    }
}
