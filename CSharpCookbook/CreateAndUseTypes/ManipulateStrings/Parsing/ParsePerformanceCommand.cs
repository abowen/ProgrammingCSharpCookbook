using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ManipulateStrings.Parsing
{
    public class ParsePerformanceCommand : DemoCommand
    {
        public ParsePerformanceCommand()
        {
            AddResource("ToString and Parse", "C# In A Nutshell, Location 10069");
        }

        public override string Description
        {
            get { return "Parsing Performance"; }
        }

        public override void ExecuteDemo()
        {
            RepeatMethod(ParseException);
            RepeatMethod(TryParse);
        }

        private static void ParseException()
        {
            int i;
            try
            {
                i = int.Parse("FAIL");
            }
            catch (Exception)
            {
                i = int.Parse("123");
            }            
        }

        private static void TryParse()
        {
            int i;
            var fail = int.TryParse("FAIL", out i);
            var success = int.TryParse("123", out i);            
        }
    }
}
