using CSharpCookbook.BaseCommands;
using CSharpCookbook.ManageProgramFlow.Asynchronous;
using CSharpCookbook.ManageProgramFlow.ManageMultithreading;

namespace CSharpCookbook.ManageProgramFlow
{
    public class ManageProgramFlowCommand : DisplayCommand
    {
        public override string Description { get { return "Manage Program Flow"; } }

        public ManageProgramFlowCommand()
        {
            AddCommand(new AsynchronousCommand());
            AddCommand(new ManageMultithreadingCommand());            
        }
    }
}
