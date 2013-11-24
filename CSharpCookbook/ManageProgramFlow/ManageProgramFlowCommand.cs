using CSharpCookbook.ManageProgramFlow.Asynchronous;

namespace CSharpCookbook.ManageProgramFlow
{
    public class ManageProgramFlowCommand : Command
    {
        public override string Description { get { return "Manage Program Flow"; } }

        public ManageProgramFlowCommand()
        {
            AddCommand(new AsynchronousCommand());            
        }
    }
}
