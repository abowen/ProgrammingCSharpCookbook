using CSharpCookbook.BaseCommands;
using CSharpCookbook.ManageProgramFlow.ManageMultithreading.Synchronize;

namespace CSharpCookbook.ManageProgramFlow.ManageMultithreading
{
    public class ManageMultithreadingCommand : DisplayCommand
    {
        public override string Description
        {
            get { return "Manage Multithreading"; }
        }

        public ManageMultithreadingCommand()
        {
            AddCommand(new LockCommand());
            AddCommand(new WaitCommand());
            AddCommand(new MutexCommand());
            AddCommand(new ThreadJoinCommand());
            AddCommand(new TaskCancelCommand());
        }
    }
}