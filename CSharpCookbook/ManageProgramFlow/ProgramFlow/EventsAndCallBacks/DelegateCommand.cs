using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ProgramFlow.EventsAndCallBacks
{
    public class DelegateCommand : DemoCommand
    {
        public DelegateCommand()
        {
            AddResource("Delegate", "http://msdn.microsoft.com/en-us/library/900fyy8e%28v=vs.110%29.aspx");
            AddResource("Delegates", "C# In A NutShell, Location 5916");            
        }

        public override string Description
        {
            get { return "Delegates"; }
        }

        public delegate void MyDelegate(int input);

        public override void ExecuteDemo()
        {
            MyDelegate myDelegate = MyMethodDelegate;
            myDelegate(7);
            myDelegate = delegate(int input) { Console.WriteLine("Delegate Delegate {0}", input); };
            myDelegate(6);
            myDelegate = input => Console.WriteLine("Anonymous Delegate {0}", input);
            myDelegate(5);
        }

        private void MyMethodDelegate(int input)
        {
            Console.WriteLine("Method Delegate {0}", input);
        }
    }
}
