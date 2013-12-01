using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ClassHierarchy.Inherit
{
    public class InterfaceCommand : DemoCommand
    {
        public InterfaceCommand()
        {
            AddResource("Interfaces", "http://msdn.microsoft.com/en-us/library/ms173156.aspx");
        }

        public override string Description
        {
            get { return "Interface Inheritance"; }
        }

        public override void ExecuteDemo()
        {
            IMyInterface myInterface = new MyInterfaceClass();
            myInterface.MyGetSetValue = "MyGetSetValue";
            Console.WriteLine(myInterface.MyGetSetValue);
            Console.WriteLine(myInterface.MyGetValue);
        }
    }

    public class MyInterfaceClass : IMyInterface
    {
        public MyInterfaceClass()
        {
            MyGetValue = "MyGetValue";
        }

        public string MyGetSetValue { get; set; }
        public string MyGetValue { get; private set; }
    }

    public interface IMyInterface
    {
        string MyGetSetValue { get; set; }
        string MyGetValue { get; }
    }
}
