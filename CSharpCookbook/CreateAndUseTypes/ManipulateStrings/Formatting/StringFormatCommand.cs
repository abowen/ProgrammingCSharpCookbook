using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ManipulateStrings.Formatting
{
    public class StringFormatCommand : DemoCommand
    {
        public StringFormatCommand()
        {
            AddResource("Composite Formatting", "http://msdn.microsoft.com/en-us/library/txafckwd%28v=vs.110%29.aspx");
            AddResource("String Format Method", "http://msdn.microsoft.com/en-us/library/system.string.format(v=vs.110).aspx");
        }

        public override string Description
        {
            get { return "String Formatting"; }
        }

        public override void ExecuteDemo()
        {
            var stringValue = "StringValue";
            Console.WriteLine("Value           : |{0}|", stringValue);
            Console.WriteLine("Left Alignment  : |{0,15}|", stringValue);
            Console.WriteLine("Right Alignment : |{0,-15}|", stringValue);            
            Console.WriteLine();
            Console.WriteLine("TABLE");
            short[] values = { Int16.MinValue, -27, 0, 1042, Int16.MaxValue };
            Console.WriteLine("{0,10}  {1,10}\n", "Decimal", "Hex");
            foreach (var value in values)
            {
                string formatString = String.Format("{0,10:G}: {0,10:X}", value);
                Console.WriteLine(formatString);
            }   
        }
    }
}
