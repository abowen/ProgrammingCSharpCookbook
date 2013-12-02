using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ManipulateStrings.StringFormatting
{
    public class NumberFormatCommand : DemoCommand
    {
        public NumberFormatCommand()
        {
            AddResource("Standard Numeric Formatting Strings", "http://msdn.microsoft.com/en-us/library/dwhawy9k%28v=vs.110%29.aspx");
            AddResource("Custom Numeric Formatting Strings", "http://msdn.microsoft.com/en-us/library/0c899ak8(v=vs.110).aspx");
        }

        public override string Description
        {
            get { return "Number Formatting"; }
        }

        public override void ExecuteDemo()
        {
            var value = 12345;
            Console.WriteLine("STANDARD");
            Console.WriteLine("Raw           : {0}", value);
            Console.WriteLine("Currency      : {0:C0}", value);
            Console.WriteLine("Decimals      : {0:N1}", value);
            Console.WriteLine("Percent       : {0:P}", value);
            Console.WriteLine("Hexadecimal   : {0:x8}", value);
            Console.WriteLine("CUSTOM");
            var decimalValue = 12345.1234;
            Console.WriteLine("Raw           : {0}", decimalValue);
            Console.WriteLine("0             : {0}", decimalValue.ToString("000000000"));
            Console.WriteLine("#             : {0}", decimalValue.ToString("#########"));
            Console.WriteLine(".             : {0}", decimalValue.ToString("######.00"));
            Console.WriteLine(",             : {0} ", decimalValue.ToString("###,"));
            Console.WriteLine("%             : {0}", decimalValue.ToString(".##%"));
            Console.WriteLine("\\             : {0}", decimalValue.ToString("\0.##%"));
            Console.WriteLine("'             : {0}", decimalValue.ToString("####, 'Thousand'"));
            Console.WriteLine("SECTION SEPARATOR");
            var negative = -1;
            var zero = 0;
            var positive = 1;
            Console.WriteLine("+1             : {0}", positive.ToString("'Positive';'Zero';'Negative'"));
            Console.WriteLine(" 0             : {0}", zero.ToString("'Positive';'Zero';'Negative'"));
            Console.WriteLine("-1             : {0}", negative.ToString("'Positive';'Zero';'Negative'"));
        }
    }
}
