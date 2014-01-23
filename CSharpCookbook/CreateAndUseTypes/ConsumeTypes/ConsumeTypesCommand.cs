using CSharpCookbook.BaseCommands;
using CSharpCookbook.CreateAndUseTypes.ConsumeTypes.Boxing;
using CSharpCookbook.CreateAndUseTypes.ConsumeTypes.Casting;

namespace CSharpCookbook.CreateAndUseTypes.ConsumeTypes
{
    public class ConsumeTypesCommand : DisplayCommand
    {
        public override string Description
        {
            get { return "Consume Types"; }
        }

        public ConsumeTypesCommand()
        {
            AddCommand(new BoxingCommand());
            AddCommand(new ConvertCommand());
            AddCommand(new CastCommand());
            AddCommand(new DynamicCommand());
            AddCommand(new ConversionPerformanceCommand());
        }
    }
}