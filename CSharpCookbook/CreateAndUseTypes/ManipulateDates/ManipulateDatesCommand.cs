using CSharpCookbook.BaseCommands;
using CSharpCookbook.CreateAndUseTypes.ManipulateDates.TimeSpans;

namespace CSharpCookbook.CreateAndUseTypes.ManipulateDates
{
    public class ManipulateDatesCommand : DisplayCommand
    {
        public override string Description
        {
            get { return "Manipulate Dates"; }
        }

        public ManipulateDatesCommand()
        {
            AddCommand(new TimeSpanCommand());
            AddCommand(new DateTimeCommand());
            AddCommand(new DateTimeOffsetCommand());
            AddCommand(new TimeZoneInfoCommand());
        }
    }
}