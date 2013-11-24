using CSharpCookbook.Interfaces;
using CSharpCookbook.ManageProgramFlow.Asynchronous.ParallelFor;
using CSharpCookbook.ManageProgramFlow.Asynchronous.PLINQ;
using CSharpCookbook.ManageProgramFlow.Asynchronous.Tasks;
using CSharpCookbook.ManageProgramFlow.Asynchronous.Threads;

namespace CSharpCookbook.ManageProgramFlow.Asynchronous
{
    public class AsynchronousCommand : ICommand
    {
        public string Description
        {
            get { return "Asynchronous"; }
        }

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
            commandTree.AddCommand(new StartNewCommand());
            commandTree.AddCommand(new ContinueWithCommand());
            commandTree.AddCommand(new WaitCommand());
            commandTree.AddCommand(new ThreadPoolCommand());
            commandTree.ExecuteCommands();
        }
    }
}