using CSharpCookbook.BaseCommands;
using CSharpCookbook.CreateAndUseTypes.CreateTypes.Types;

namespace CSharpCookbook.CreateAndUseTypes.CreateTypes
{
    public class CreateTypesCommand : DisplayCommand
    {
        public override string Description
        {
            get { return "Create Types"; }
        }

        public CreateTypesCommand()
        {
            AddCommand(new ClassCommand());
            AddCommand(new StructCommand());
            AddCommand(new GenericClassCommand());
        }
    }
}