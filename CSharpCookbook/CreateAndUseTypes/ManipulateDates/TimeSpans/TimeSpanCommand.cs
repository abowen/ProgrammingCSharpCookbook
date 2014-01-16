using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ManipulateDates.TimeSpans
{
    public class TimeSpanCommand : DemoCommand
    {
        public TimeSpanCommand()
        {
            AddResource("Pluralsight, Mastering C# 4.0, DateTime", "http://pluralsight.com/training/Player?author=jon-skeet&name=skeet-csharp4-m13-datetime&mode=live&clip=0&course=skeet-csharp4");
        }

        public override string Description
        {
            get { return "Time Span"; }
        }

        public override void ExecuteDemo()
        {
            var fiveSeconds = TimeSpan.FromSeconds(5);            
            var halfMinute = TimeSpan.FromMinutes(0.5);
            var thirtyFiveSeconds = new TimeSpan(0, 0, 0, 0, 35000);
            var isEqual = (fiveSeconds + halfMinute) == thirtyFiveSeconds;            
            Console.WriteLine("Total Milliseconds {0}", thirtyFiveSeconds.TotalMilliseconds);
            Console.WriteLine("Milliseconds {0}", thirtyFiveSeconds.Milliseconds);
            Console.WriteLine("IsEqual {0}", isEqual);            
        }
    }
}
