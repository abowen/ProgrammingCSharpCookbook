using CSharpCookbook.BaseCommands;
using CSharpCookbook.CreateAndUseTypes;
using CSharpCookbook.ImplementDataAccess;
using CSharpCookbook.ManageProgramFlow;
using CSharpCookbook.Security;

namespace CSharpCookbook
{
    public class CSharpCommand : DisplayCommand
    {
        public override string Description { get { return @"Programming in C#"; } }

        public CSharpCommand()
        {
            AddCommand(new ManageProgramFlowCommand());
            AddCommand(new CreateAndUseTypesCommand());
            AddCommand(new DebuggingAndSecurityCommand());
            AddCommand(new ImplementDataAccessCommand());
        }
    }
}
