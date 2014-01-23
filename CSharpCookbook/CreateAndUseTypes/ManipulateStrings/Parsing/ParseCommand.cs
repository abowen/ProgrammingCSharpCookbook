using System;
using System.Globalization;
using System.Threading;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ManipulateStrings.Parsing
{
    public class ParseCommand : DemoCommand
    {
        public ParseCommand()
        {
            AddResource("ToString and Parse", "C# In A Nutshell, Location 10069");
        }

        public override string Description
        {
            get { return "Parsing"; }
        }

        public override void ExecuteDemo()
        {
            var germanyCulture = new CultureInfo("de");

            CultureTest(ParseInput, Thread.CurrentThread.CurrentCulture);            
            CultureTest(ParseInput, germanyCulture);
        }

        public void ParseInput()
        {
            var userInput = "1.234";
            var output = double.Parse(userInput);
            Console.WriteLine(output);
        }
    }
}
