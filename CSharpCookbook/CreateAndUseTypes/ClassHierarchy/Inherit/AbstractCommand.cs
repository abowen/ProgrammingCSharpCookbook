using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ClassHierarchy.Inherit
{
    public class AbstractCommand : DemoCommand
    {
        public AbstractCommand()
        {
            AddResource("Abstract", "http://msdn.microsoft.com/en-us/library/sf985hc5.aspx");
        }

        public override string Description
        {
            get { return "Abstract Inheritance"; }
        }

        public override void ExecuteDemo()
        {
            var myCustomAbstractClass = new MyAbstractClass();
            Console.WriteLine(myCustomAbstractClass.MyAbstractValue);
            myCustomAbstractClass.MyAbstractMethod();
        }
    }

    public abstract class MyAbstract
    {
        protected MyAbstract()
        {
            Console.WriteLine("MyAbstract");
        }

        public abstract void MyAbstractMethod();

        public string MyAbstractValue = "MyAbstractValue";
    }

    public class MyAbstractClass : MyAbstract
    {
        public MyAbstractClass()
        {
            Console.WriteLine("MyAbstractClass");            
        }

        public override void MyAbstractMethod()
        {
            Console.WriteLine("MyAbstractClassMethod");
        }
    }    
}
