using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ProgramFlow.Operators
{
    public class NullCoalescingCommand : DemoCommand
    {
        public NullCoalescingCommand()
        {
            AddResource("?? Operator", "http://msdn.microsoft.com/en-us/library/ms173224.aspx");
        }

        public override string Description
        {
            get { return "?? Operator"; }
        }

        public override void ExecuteDemo()
        {
            string nullString = null;
            var outputValue = nullString ?? "No Value";
            Console.WriteLine("Step A {0}", outputValue);

            nullString = "New Value";
            outputValue = nullString ?? "No Value";
            Console.WriteLine("Step B {0}", outputValue);
        }
    }
}
