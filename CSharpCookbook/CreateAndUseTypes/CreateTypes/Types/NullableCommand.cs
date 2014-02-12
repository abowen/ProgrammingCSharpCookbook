using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.CreateTypes.Types
{
    public class NullableCommand : DemoCommand
    {
        public NullableCommand()
        {
            AddResource("Nullable Types", @"http://msdn.microsoft.com/en-us/library/1t3y8s4s.aspx");
        }

        public override string Description
        {
            get { return "Nullable"; }
        }

        public override void ExecuteDemo()
        {
            int? value = null;

            Console.WriteLine("Value {0}", value);
            Console.WriteLine("Set Value to 5");
            value = 5;
            Console.WriteLine("Value {0}", value);
            Console.WriteLine("Value Type {0}", value.GetType());
        }
    }
}
