using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ManipulateDates.TimeSpans
{
    public class TimeZoneInfoCommand : DemoCommand
    {
        public TimeZoneInfoCommand()
        {            
            AddResource("Pluralsight, Mastering C# 4.0, DateTime", "http://pluralsight.com/training/Player?author=jon-skeet&name=skeet-csharp4-m13-datetime&mode=live&clip=0&course=skeet-csharp4");
        }

        public override string Description
        {            
            get { return "Time Zone Info"; }
        }

        public override void ExecuteDemo()
        {
            var zone = TimeZoneInfo.Local;
            var dateTimeDst = new DateTime(2013, 1, 1, 10, 0, 0);
            var dateTimeNonDst = new DateTime(2013, 7, 1, 10, 0, 0);
            Console.WriteLine("Zone: {0}", zone);
            Console.WriteLine("Date in DST     : {0}", dateTimeDst);
            Console.WriteLine("Date not in DST : {0}", dateTimeNonDst);
            Console.WriteLine("Offset in DST     : {0}", zone.GetUtcOffset(dateTimeDst));
            Console.WriteLine("Offset not in DST : {0}", zone.GetUtcOffset(dateTimeNonDst));
            Console.WriteLine("Is DST in DST     : {0}", zone.IsDaylightSavingTime(dateTimeDst));
            Console.WriteLine("Is DST not in DST : {0}", zone.IsDaylightSavingTime(dateTimeNonDst));            
        }        
    }
}
