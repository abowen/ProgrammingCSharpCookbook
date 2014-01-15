using CSharpCookbook.BaseCommands;
using CSharpCookbook.CreateAndUseTypes.ManipulateStrings.StringFormatting;
using CSharpCookbook.CreateAndUseTypes.ManipulateStrings.StringHandling;
using CSharpCookbook.CreateAndUseTypes.ManipulateStrings.StringMatching;

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
        }
    }
}