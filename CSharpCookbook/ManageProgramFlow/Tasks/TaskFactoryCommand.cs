using System;
using System.Threading;
using System.Threading.Tasks;
using CSharpCookbook.Interfaces;

namespace CSharpCookbook.ManageProgramFlow.Tasks
{
    public class TaskFactoryCommand : ICommand, IMsdn
    {
        public string Description { get { return "Factory.StartNew()"; } }
        public void Execute()
        {
            Console.WriteLine("TaskFactoryCommand Entry");
            Task.Factory.StartNew(Calculate);
            Console.WriteLine("TaskFactoryCommand Complete");
            Thread.Sleep(5000);
        }

        private static void Calculate()
        {
            Console.WriteLine("TaskFactoryCommand Process Entry");
            Thread.Sleep(2000);
            Console.WriteLine("TaskFactoryCommand Process Complete");
        }

        public string Title { get { return "Task Class"; } }
        public string Website { get { return @"http://msdn.microsoft.com/en-us/library/system.threading.tasks.task.aspx"; } }
    }
}
