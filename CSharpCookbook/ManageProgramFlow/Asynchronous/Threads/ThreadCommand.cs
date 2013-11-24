using System;
using System.Threading;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.Asynchronous.Threads
{
    public class ThreadCommand : DemoCommand
    {
        public ThreadCommand()
        {
            AddResource("Threading Tutorial", "http://msdn.microsoft.com/en-us/library/aa645740%28v=vs.71%29.aspx");
        }

        public override string Description { get { return "Thread"; } }

        public override void ExecuteDemo()
        {
            Console.WriteLine("Main Thread ID {0}", Thread.CurrentThread.ManagedThreadId);
            var thread = new Thread(ThreadWork)
            {
                IsBackground = true
            };
            thread.Start();
            Thread.Sleep(100);            
        }        

        private void ThreadWork()
        {
            Console.WriteLine("Sub Thread ID {0}", Thread.CurrentThread.ManagedThreadId);            
        }        
    }
}
