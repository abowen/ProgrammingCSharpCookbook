using System;
using System.Threading;
using CSharpCookbook.Interfaces;

namespace CSharpCookbook.ManageProgramFlow.Asynchronous.Threads
{
    public class ThreadPoolCommand : ICommand, IMsdn
    {
        public string Description { get { return "ThreadPool"; } }

        public void Execute()
        {
            Console.WriteLine("ThreadPoolCommand Entry");
            ThreadPool.QueueUserWorkItem(new WaitCallback(ExplicitDelegate));
            ThreadPool.QueueUserWorkItem(ImplicitDelegate);
            ThreadPool.QueueUserWorkItem(state => Console.WriteLine("ThreadPoolCommand Anonymous Method"));
            Thread.Sleep(1000);
            Console.WriteLine("ThreadPoolCommand Complete");
        }

        private void ExplicitDelegate(object state)
        {
            Console.WriteLine("ThreadPoolCommand ExplicitDelegate");
        }

        private void ImplicitDelegate(object state)
        {
            Console.WriteLine("ThreadPoolCommand ImplicitDelegate");
        }

        public string Title { get { return "Thread Pooling"; } }
        public string Website { get { return @"http://msdn.microsoft.com/en-us/library/h4732ks0.aspx"; } }
    }
}
