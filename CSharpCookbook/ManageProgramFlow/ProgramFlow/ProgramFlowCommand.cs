using CSharpCookbook.BaseCommands;
using CSharpCookbook.ManageProgramFlow.ProgramFlow.ConditionalLogic;
using CSharpCookbook.ManageProgramFlow.ProgramFlow.Iteration;
using CSharpCookbook.ManageProgramFlow.ProgramFlow.Operators;

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
            AddCommand(new GotoCaseCommand());
            AddCommand(new NullCoalescingCommand());
            AddCommand(new ConditionalCommand());
            AddCommand(new BitwiseCommand());
            AddCommand(new GlobalCommand());
            AddCommand(new EnumerableCommand());
            AddCommand(new IndexerCommand());
        }
    }
}