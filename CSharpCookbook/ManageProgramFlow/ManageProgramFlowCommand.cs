using CSharpCookbook.BaseCommands;
using CSharpCookbook.ManageProgramFlow.Asynchronous;
using CSharpCookbook.ManageProgramFlow.EventsAndCallBacks;
using CSharpCookbook.ManageProgramFlow.Exceptions;
using CSharpCookbook.ManageProgramFlow.ManageMultithreading;
using CSharpCookbook.ManageProgramFlow.ProgramFlow;

namespace CSharpCookbook.ManageProgramFlow
{
    public class ManageProgramFlowCommand : DisplayCommand
    {
        public override string Description { get { return "Manage Program Flow"; } }

        public ManageProgramFlowCommand()
        {
            AddCommand(new AsynchronousCommand());
            AddCommand(new ManageMultithreadingCommand());
            AddCommand(new ProgramFlowCommand());
            AddCommand(new EventsAndCallbacksCommand());
            AddCommand(new ExceptionsCommand());
        }
    }
}
