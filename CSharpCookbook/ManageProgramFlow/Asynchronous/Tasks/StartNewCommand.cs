using System;
using System.Threading;
using System.Threading.Tasks;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.Asynchronous.Tasks
{
    public class StartNewCommand : DemoCommand
    {
        public StartNewCommand()
        {
            AddResource("Task Class", "http://msdn.microsoft.com/en-us/library/system.threading.tasks.task.aspx");
        }

        public override string Description { get { return "Factory.StartNew"; } }
        public override void ExecuteDemo()
        {            
            Task.Factory.StartNew(Calculate);
            Thread.Sleep(5000);
        }

        private static void Calculate()
        {
            Console.WriteLine("StartNewCommand Process Entry");
            Thread.Sleep(2000);
            Console.WriteLine("StartNewCommand Process Complete");
        }
    }
}
