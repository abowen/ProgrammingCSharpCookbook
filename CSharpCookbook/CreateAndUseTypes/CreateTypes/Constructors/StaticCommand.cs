using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.CreateTypes.Constructors
{
    public class StaticCommand : DemoCommand
    {
        public StaticCommand()
        {
            AddResource("Static Constructors", "http://msdn.microsoft.com/en-us/library/k9x6w0hc.aspx");
        }

        public override string Description
        {
            get { return "Static Constructor"; }
        }

        public override void ExecuteDemo()
        {
            var works = new MyCustomStaticConstructorClass();            
        }
    }

    public class MyCustomStaticConstructorClass
    {        
        static readonly long Value;
        
        static MyCustomStaticConstructorClass()
        {
            Value = 123;
        }

        public MyCustomStaticConstructorClass()
        {
            Console.WriteLine("MyCustomStaticConstructorClass {0}", Value);
        }
    }
}
