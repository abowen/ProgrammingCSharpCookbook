using System;
using System.Threading;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ManageMultithreading.Synchronize
{
    public class AutoResetEventCommand : DemoCommand
    {
        public AutoResetEventCommand()
        {
            AddResource("Thread Synchronization", "http://msdn.microsoft.com/en-us/library/ms173179.aspx");
            AddResource("AutoResetEvent Class", "http://msdn.microsoft.com/en-us/library/system.threading.autoresetevent.aspx");
        }

        public override string Description { get { return "AutoResetEvent"; } }

        private static readonly AutoResetEvent AutoResetEvent = new AutoResetEvent(false);

        public override void ExecuteDemo()
        {
            for (var i = 0; i < 3; i++)
            {
                var t = new Thread(Process);
                t.Start();
            }
            Thread.Sleep(250);

            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine("Press Enter to release another thread.");
                Console.ReadLine();
                AutoResetEvent.Set();
                Thread.Sleep(250);
            }            
        }

        private static void Process()
        {
            var id = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine("Thread {0} waiting", id);
            AutoResetEvent.WaitOne();
            Console.WriteLine("Thread {0} released", id);            
        }
    }
}
