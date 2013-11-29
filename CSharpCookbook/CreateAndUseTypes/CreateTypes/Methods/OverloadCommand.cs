using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.CreateTypes.Methods
{
    public class OverloadCommand : DemoCommand
    {
        public OverloadCommand()
        {
            AddResource("Member Overloading", "http://msdn.microsoft.com/en-us/library/ms229029(v=vs.110).aspx");
        }

        public override string Description
        {
            get { return "Overloading Methods"; }
        }

        public override void ExecuteDemo()
        {
            MyOverloadedMethod("Example");
            MyOverloadedMethod(true);
        }

        public void MyOverloadedMethod(string stringValue)
        {
            Console.WriteLine("String {0}", stringValue);
        }

        public void MyOverloadedMethod(bool boolValue)
        {
            Console.WriteLine("Bool {0}", boolValue);
        }
    }

    
}
