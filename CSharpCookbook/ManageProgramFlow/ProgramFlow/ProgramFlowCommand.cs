using CSharpCookbook.BaseCommands;
using CSharpCookbook.ManageProgramFlow.ProgramFlow.ConditionalLogic;

namespace CSharpCookbook.ManageProgramFlow.ProgramFlow
{
    public class ProgramFlowCommand : DisplayCommand
    {
        public override string Description
        {
            get { return "Program Flow"; }
        }

        public ProgramFlowCommand()
        {
            AddCommand(new SwitchCommand());
            
        }
    }
}