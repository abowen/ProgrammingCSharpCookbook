using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.CreateTypes.Methods
{
    public class VirtualCommand : DemoCommand
    {
        public VirtualCommand()
        {
            AddResource("virtual", "http://msdn.microsoft.com/en-us/library/9fkccyh4(v=vs.120).ASPX");
            AddResource("override", "http://msdn.microsoft.com/en-us/library/ebca9ah3.ASPX");
        }

        public override string Description
        {
            get { return "Virtual Methods"; }
        }

        public override void ExecuteDemo()
        {
            var instance = new MyInheritedMethodClass();
            instance.MyCustomMethod();
        }        
    }

    public class MyVirtualMethodClass
    {
        public virtual void MyCustomMethod()
        {
            Console.WriteLine("MyCustomMethod");
        }
    }

    public class MyInheritedMethodClass : MyVirtualMethodClass
    {
        public override void MyCustomMethod()
        {
            Console.WriteLine("MyCustomMethod Override");            
        }
    }
}
