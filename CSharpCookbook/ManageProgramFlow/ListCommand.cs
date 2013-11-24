using CSharpCookbook.Interfaces;
using CSharpCookbook.ManageProgramFlow.ParallelFor;
using CSharpCookbook.ManageProgramFlow.PLINQ;
using CSharpCookbook.ManageProgramFlow.Tasks;

namespace CSharpCookbook.ManageProgramFlow
{
    public class ListCommand : ICommand
    {
        public string Description { get { return "Manage Program Flow"; } }

        public void Execute()
        {
            var commandTree = new CommandTree();
            commandTree.AddCommand(new ParallelForCommand());
            commandTree.AddCommand(new ParallelForBreakCommand());
            commandTree.AddCommand(new ParallelForStopCommand());
            commandTree.AddCommand(new ParallelForCancelCommand());            
            commandTree.AddCommand(new AsParallelCommand());
            commandTree.AddCommand(new AsOrderedCommand());
            commandTree.AddCommand(new ForAllCommand());
            commandTree.AddCommand(new TaskFactoryCommand());
            commandTree.AddCommand(new ContinueWithCommand());
            commandTree.AddCommand(new TaskWaitCommand());
            commandTree.ExecuteCommands();
        }
    }
}
