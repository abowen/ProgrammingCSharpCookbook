using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ClassHierarchy.Interfaces
{
    public class InterfaceCommand : DemoCommand
    {
        public InterfaceCommand()
        {
            AddResource("Interfaces", "http://msdn.microsoft.com/en-us/library/ms173156.aspx");
        }

        public override string Description
        {
            get { return "Interfaces"; }
        }

        public override void ExecuteDemo()
        {
            ICustomInterface customInterface = new MyCustomInterfaceClass();
            customInterface.MyGetSetValue = "MyGetSetValue";
            Console.WriteLine(customInterface.MyGetSetValue);
            Console.WriteLine(customInterface.MyGetValue);
        }
    }

    public class MyCustomInterfaceClass : ICustomInterface
    {
        public MyCustomInterfaceClass()
        {
            MyGetValue = "MyGetValue";
        }

        public string MyGetSetValue { get; set; }
        public string MyGetValue { get; private set; }
    }

    public interface ICustomInterface
    {
        string MyGetSetValue { get; set; }
        string MyGetValue { get; }
    }
}
