using System;
using System.Text.RegularExpressions;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ManipulateStrings.StringMatching
{
    public class RegularExpressionCommand : DemoCommand
    {
        public RegularExpressionCommand()
        {
            AddResource("MSDN Regular Expressions", "http://msdn.microsoft.com/en-us/library/hs600312(v=vs.110).aspx");
        }

        public override string Description
        {
            get { return "Regular Expressions"; }
        }

        public override void ExecuteDemo()
        {
            WhiteSpaceSplit();
            NumberSequenceSplit();
            LogFileMatch();
            HelloWorldReplace();
        }

        private static void WhiteSpaceSplit()
        {
            var pattern = new Regex(" ");
            var text = "Andrew Bowen";
            Console.WriteLine("Pattern: {0}", pattern);
            Console.WriteLine("Text:    {0}", text);
            var words = pattern.Split(text);
            foreach (var word in words)
            {
                Console.WriteLine("Word: {0}", word);
            }
        }

        private static void NumberSequenceSplit()
        {
            var pattern = new Regex(@"\d");
            var text = "Andrew0James2Bowen";
            Console.WriteLine("Pattern: {0}", pattern);
            Console.WriteLine("Text:    {0}", text);
            var words = pattern.Split(text);
            foreach (var word in words)
            {
                Console.WriteLine("Word: {0}", word);
            }
        }

        private static void HelloWorldReplace()
        {
            var pattern = new Regex(@"[aeiou]");
            var text = "Hello, world";
            Console.WriteLine("Pattern: {0}", pattern);
            Console.WriteLine("Text:    {0}", text);
            var result = pattern.Replace(text, "?");
            Console.WriteLine("Result   {0}", result);
        }

        private static void LogFileMatch()
        {            
            // <> Grouping
            // \S nonspace characters
            //  + one or many
            //  * zero or many
            //  . any character
            // \. decimal
            // [abc] any of the characters abc
            // [^abc] any character that is not abc
            var pattern = new Regex(@"(?<level>\S+) " +
                                    @"(?<timestamp>\d{2}/\d{2}/\d{4} \d{2}:\d{2}:\d{2}\.\d{3}) " +
                                    @"---(?<category>[^-]+)--- " +
                                    @"(?<message>.*)");

            var text = "WARNING 05/10/2013 13:15:15.000 ---FooBar--- The Foo has been Barred";
            
            Console.WriteLine("Pattern: {0}", pattern);
            Console.WriteLine("Text:    {0}", text);
            var match = pattern.Match(text);
            if (match.Success)
            {
                Console.WriteLine(match.Groups["level"]);
                Console.WriteLine(match.Groups["timestamp"]);
                Console.WriteLine(match.Groups["category"]);
                Console.WriteLine(match.Groups["message"]);
            }
            else
            {
                Console.WriteLine("Not Matched");
            }
        }
    }
}
