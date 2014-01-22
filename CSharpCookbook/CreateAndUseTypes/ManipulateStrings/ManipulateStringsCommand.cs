using CSharpCookbook.BaseCommands;
using CSharpCookbook.CreateAndUseTypes.ManipulateStrings.Formatting;
using CSharpCookbook.CreateAndUseTypes.ManipulateStrings.Matching;
using CSharpCookbook.CreateAndUseTypes.ManipulateStrings.Parsing;
using CSharpCookbook.CreateAndUseTypes.ManipulateStrings.Streams;
using CSharpCookbook.CreateAndUseTypes.ManipulateStrings.StringHandling;

namespace CSharpCookbook.CreateAndUseTypes.ManipulateStrings
{
    public class ManipulateStringsCommand : DisplayCommand
    {
        public override string Description
        {
            get { return "Manipulate Strings"; }
        }

        public ManipulateStringsCommand()
        {
            AddCommand(new StringFormatCommand());
            AddCommand(new NumberFormatCommand());
            AddCommand(new DateFormatCommand());
            AddCommand(new EscapeCharactersCommand());
            AddCommand(new RegularExpressionCommand());
            AddCommand(new EncodingCommand());
            AddCommand(new CultureCommand());
            AddCommand(new SortingCommand());
            AddCommand(new StreamReaderWriterCommand());
            AddCommand(new StringReaderWriterCommand());
            AddCommand(new ParseCommand());
            AddCommand(new ParsePerformanceCommand());
        }
    }
}