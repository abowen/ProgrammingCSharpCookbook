using System;
using System.Globalization;
using System.Threading;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ManipulateStrings.StringHandling
{
    public class CultureCommand : DemoCommand
    {
        public CultureCommand()
        {
            AddResource("Pluralsight, Mastering C# 4.0", "http://pluralsight.com/training/Courses/TableOfContents/skeet-csharp4");
        }

        public override string Description
        {
            get { return "Culture"; }
        }

        public override void ExecuteDemo()
        {
            var cultureInfo = CultureInfo.CreateSpecificCulture("tr");
            Thread.CurrentThread.CurrentCulture = cultureInfo;

            var text = "mail";
            var textUpper = "MAIL";

            Console.WriteLine("Culture: {0}", cultureInfo);
            Console.WriteLine("{0} {1} {2}", text, textUpper, text.ToUpper());
            var equal = textUpper == text.ToUpper();
            Console.WriteLine("Equals: {0}", equal);
            var equalInvarient = text.Equals(textUpper, StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine("Equals Ignore: {0}", equalInvarient);
        }
    }
}
