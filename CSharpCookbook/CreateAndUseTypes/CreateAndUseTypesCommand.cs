using CSharpCookbook.BaseCommands;
using CSharpCookbook.CreateAndUseTypes.ClassHierarchy;
using CSharpCookbook.CreateAndUseTypes.ConsumeTypes;
using CSharpCookbook.CreateAndUseTypes.CreateTypes;
using CSharpCookbook.CreateAndUseTypes.Encapsulation;

namespace CSharpCookbook.CreateAndUseTypes
{
    public class CreateAndUseTypesCommand : DisplayCommand
    {
        public override string Description { get { return "Create And Use Types"; } }

        public CreateAndUseTypesCommand()
        {
            AddCommand(new CreateTypesCommand());
            AddCommand(new ConsumeTypesCommand());
            AddCommand(new EncapsulationCommand());
            AddCommand(new ClassHierarchyCommand());
        }
    }
}
