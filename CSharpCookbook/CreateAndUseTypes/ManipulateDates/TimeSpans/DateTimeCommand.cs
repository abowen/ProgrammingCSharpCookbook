using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ManipulateDates.TimeSpans
{
    public class DateTimeCommand : DemoCommand
    {
        public DateTimeCommand()
        {                
            AddResource("Pluralsight, Mastering C# 4.0, DateTime", "http://pluralsight.com/training/Player?author=jon-skeet&name=skeet-csharp4-m13-datetime&mode=live&clip=0&course=skeet-csharp4");
        }

        public override string Description
        {            
            get { return "Date Time"; }
        }

        public override void ExecuteDemo()
        {            
            DateTimeKindDemo();
            UtcNowDemo();
            UnspecifiedKindDemo();
        }

        private static void UnspecifiedKindDemo()
        {
            Console.WriteLine("*** Unspecified ***");
            var unspecifiedTime = new DateTime(2014, 01, 16, 11, 37, 0, DateTimeKind.Unspecified);
            Console.WriteLine("Unspecified         : {0}", unspecifiedTime);
            // Treats unspec as UTC, changes to local
            Console.WriteLine("Unspecified as Local: {0}", unspecifiedTime.ToLocalTime());
            // Treats unspec as local, changes to UTC
            Console.WriteLine("Unspecified as UTC  : {0}", unspecifiedTime.ToUniversalTime());
        }

        private static void UtcNowDemo()
        {
            Console.WriteLine("*** UTC Now ***");
            var utcNow = DateTime.UtcNow;
            var utcNowAsUtc = utcNow.ToUniversalTime();
            Console.WriteLine("UTC Now         : {0}", utcNow);
            Console.WriteLine("UTC Now as UTC  : {0}", utcNowAsUtc);
        }

        private static void DateTimeKindDemo()
        {
            Console.WriteLine("*** DateTimeKind ***");
            var myOffset = -11;
            var myHour = 11;
            var myTime = new DateTime(2014, 01, 16, myHour, 37, 0, DateTimeKind.Local);
            var utcTime = new DateTime(2014, 01, 16, myHour + myOffset, 37, 0, DateTimeKind.Utc);
            var myTimeAsUtc = myTime.ToUniversalTime();
            Console.WriteLine("Mine       : {0}", myTime);
            Console.WriteLine("Mine as UTC: {0}", myTimeAsUtc);
            Console.WriteLine("UTC        : {0}", utcTime);            
        }
    }
}
