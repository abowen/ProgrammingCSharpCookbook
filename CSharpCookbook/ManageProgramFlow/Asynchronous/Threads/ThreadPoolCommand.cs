using System;
using System.Threading;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.Asynchronous.Threads
{
    public class ThreadPoolCommand : DemoCommand
    {
        public ThreadPoolCommand()
        {
            AddResource("Thread Pooling", "http://msdn.microsoft.com/en-us/library/h4732ks0.aspx");
        }

        public override string Description { get { return "ThreadPool"; } }

        public override void ExecuteDemo()
        {            
            ThreadPool.QueueUserWorkItem(new WaitCallback(ExplicitDelegate));
            ThreadPool.QueueUserWorkItem(ImplicitDelegate);
            ThreadPool.QueueUserWorkItem(state => Console.WriteLine("ThreadPoolCommand Anonymous Method"));
            Thread.Sleep(1000);            
        }

        private void ExplicitDelegate(object state)
        {
            Console.WriteLine("ThreadPoolCommand ExplicitDelegate");
        }

        private void ImplicitDelegate(object state)
        {
            Console.WriteLine("ThreadPoolCommand ImplicitDelegate");
        }
    }
}
