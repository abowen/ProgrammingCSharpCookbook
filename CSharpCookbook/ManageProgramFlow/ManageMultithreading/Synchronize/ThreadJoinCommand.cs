using System;
using System.Threading;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ManageMultithreading.Synchronize
{
    public class ThreadJoinCommand : DemoCommand
    {
        public ThreadJoinCommand()
        {
            AddResource("Thread.Join Method", "http://msdn.microsoft.com/en-us/library/system.threading.thread.join.aspx");
        }

        public override string Description { get { return "Thread.Join"; } }

        public override void ExecuteDemo()
        {            
            var thread = new Thread(() =>
            {
                Console.WriteLine("Entered sub thread {0}", Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(4000);                
            });
            thread.Start();

            Console.WriteLine("Main thread {0} waiting for sub thread {1}", Thread.CurrentThread.ManagedThreadId, thread.ManagedThreadId);
            thread.Join();
            Console.WriteLine("Sub thread Returned");            
        }             
    }
}
