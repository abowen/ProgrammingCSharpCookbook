using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ManipulateStrings.StringFormatting
{
    public class StringFormatCommand : DemoCommand
    {
        public StringFormatCommand()
        {
            AddResource("Composite Formatting", "http://msdn.microsoft.com/en-us/library/txafckwd%28v=vs.110%29.aspx");
        }

        public override string Description
        {
            get { return "String Formatting"; }
        }

        public override void ExecuteDemo()
        {
            var value = "StringValue";
            Console.WriteLine("Value           : |{0}|", value);
            Console.WriteLine("Left Alignment  : |{0,15}|", value);
            Console.WriteLine("Right Alignment : |{0,-15}|", value);            
        }
    }
}
