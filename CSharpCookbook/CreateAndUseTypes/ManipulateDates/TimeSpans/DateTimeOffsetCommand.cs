using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ManipulateDates.TimeSpans
{
    public class DateTimeOffsetCommand : DemoCommand
    {
        public DateTimeOffsetCommand()
        {            
            AddResource("Pluralsight, Mastering C# 4.0, DateTime", "http://pluralsight.com/training/Player?author=jon-skeet&name=skeet-csharp4-m13-datetime&mode=live&clip=0&course=skeet-csharp4");
        }

        public override string Description
        {            
            get { return "Date Time Offset"; }
        }

        public override void ExecuteDemo()
        {
            var datetimeOffset = new DateTimeOffset(2014, 01, 16, 13, 32, 0, TimeSpan.FromHours(11));
            Console.WriteLine("DateTimeOffset          : {0}", datetimeOffset);
            Console.WriteLine("DateTimeOffset as Local : {0}", datetimeOffset.ToLocalTime());
            Console.WriteLine("DateTimeOffset as UTC   : {0}", datetimeOffset.ToUniversalTime());
        }        
    }
}
