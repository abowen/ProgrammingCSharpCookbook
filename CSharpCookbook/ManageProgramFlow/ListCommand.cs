using CSharpCookbook.ManageProgramFlow.ParallelFor;
using CSharpCookbook.ManageProgramFlow.PLINQ;

namespace CSharpCookbook.ManageProgramFlow
{
    public class ListCommand : ICommand
    {
        public string Description { get { return "Parallel.For"; } }
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
            commandTree.ExecuteCommands();
        }
    }
}
