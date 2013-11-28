using CSharpCookbook.BaseCommands;
using CSharpCookbook.CreateAndUseTypes.CreateTypes;

namespace CSharpCookbook.CreateAndUseTypes
{
    public class CreateAndUseTypesCommand : DisplayCommand
    {
        public override string Description { get { return "Create And Use Types"; } }

        public CreateAndUseTypesCommand()
        {
            AddCommand(new CreateTypesCommand());
        }
    }
}
