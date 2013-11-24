using System;
using System.Threading;
using System.Threading.Tasks;
using CSharpCookbook.Interfaces;

namespace CSharpCookbook.ManageProgramFlow.Asynchronous.Tasks
{
    public class StartNewCommand : Command, IMsdn
    {
        public override string Description { get { return "Factory.StartNew"; } }
        public override void ExecuteCommand()
        {
            Console.WriteLine("StartNewCommand Entry");
            Task.Factory.StartNew(Calculate);
            Console.WriteLine("StartNewCommand Complete");
            Thread.Sleep(5000);
        }

        private static void Calculate()
        {
            Console.WriteLine("StartNewCommand Process Entry");
            Thread.Sleep(2000);
            Console.WriteLine("StartNewCommand Process Complete");
        }

        public string Title { get { return "Task Class"; } }
        public string Website { get { return @"http://msdn.microsoft.com/en-us/library/system.threading.tasks.task.aspx"; } }
    }
}
