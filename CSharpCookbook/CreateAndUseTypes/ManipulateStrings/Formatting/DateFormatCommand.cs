using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ManipulateStrings.Formatting
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
            Console.WriteLine("STANDARD");
            Console.WriteLine("Raw                     : {0}", value);
            Console.WriteLine("d - Short Date          : {0:d}", value);
            Console.WriteLine("t - Short Time          : {0:t}", value);
            Console.WriteLine("D - Full Date           : {0:D}", value);
            Console.WriteLine("T - Full Time           : {0:T}", value);
            Console.WriteLine("f - Verbose Date Time   : {0:f}", value);
            Console.WriteLine("G - Full Date Time      : {0:G}", value);
            Console.WriteLine("u - Universal Date Time : {0:u}", value);
            Console.WriteLine("CUSTOM");            
            Console.WriteLine("dd                      : {0}", value.ToString("dd"));
            Console.WriteLine("ddd                     : {0}", value.ToString("ddd"));
            Console.WriteLine("dddd                    : {0}", value.ToString("dddd"));
            Console.WriteLine("MM                      : {0}", value.ToString("MM"));
            Console.WriteLine("MMM                     : {0}", value.ToString("MMM"));
            Console.WriteLine("MMMM                    : {0}", value.ToString("MMMM"));
            Console.WriteLine("yy                      : {0}", value.ToString("yy"));
            Console.WriteLine("yyyy                    : {0}", value.ToString("yyyy"));            
            Console.WriteLine("HH (24)                 : {0}", value.ToString("HH"));            
            Console.WriteLine("hh                      : {0}", value.ToString("hh"));
            Console.WriteLine("mm                      : {0}", value.ToString("mm"));
            Console.WriteLine("ss                      : {0}", value.ToString("ss"));
            Console.WriteLine("tt                      : {0}", value.ToString("tt"));            
        }
    }
}
