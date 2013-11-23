using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpCookbook.ManageProgramFlow.Tasks
{
    public class TaskFactoryCommand : ICommand
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
    }
}
