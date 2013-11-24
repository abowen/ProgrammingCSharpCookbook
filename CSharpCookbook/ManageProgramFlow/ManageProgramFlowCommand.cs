using CSharpCookbook.Interfaces;
using CSharpCookbook.ManageProgramFlow.Asynchronous;

namespace CSharpCookbook.ManageProgramFlow
{
    public class ManageProgramFlowCommand : ICommand
    {
        public string Description { get { return "Manage Program Flow"; } }

        public void Execute()
        {
            var commandTree = new CommandTree();
            commandTree.AddCommand(new AsynchronousCommand());
            commandTree.ExecuteCommands();
        }
    }
}
