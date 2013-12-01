using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ManipulateStrings.StringFormatting
{
    public class DateFormatCommand : DemoCommand
    {
        public DateFormatCommand()
        {
            AddResource("DateTime Formatting Strings", "http://msdn.microsoft.com/en-us/library/az4se3k1%28v=vs.110%29.aspx");
        }

        public override string Description
        {
            get { return "Date Formatting"; }
        }

        public override void ExecuteDemo()
        {
            var value = DateTime.Now;
            Console.WriteLine("Raw                 : {0}", value);
            Console.WriteLine("Short Date          : {0:d}", value);
            Console.WriteLine("Short Time          : {0:t}", value);
            Console.WriteLine("Full Date           : {0:D}", value);
            Console.WriteLine("Full Time           : {0:T}", value);
            Console.WriteLine("Verbose Date Time   : {0:f}", value);
            Console.WriteLine("Full Date Time      : {0:G}", value);
            Console.WriteLine("Universal Date Time : {0:u}", value);
        }
    }
}
