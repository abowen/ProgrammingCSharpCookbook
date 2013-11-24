using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ManageMultithreading.Synchronize
{
    public class LockCommand : DemoCommand
    {

        public LockCommand()
        {
            AddResource("Monitors", @"http://msdn.microsoft.com/en-us/library/hf5de04k.aspx");
        }

        public override string Description
        {
            get { return "Lock"; }
        }       

        private int _value;
        private readonly object _lockObject = new object();

        public override void ExecuteDemo()
        {
            Console.WriteLine("Lock Start");
            var taskA = Task.Factory.StartNew(AddValue);
            var taskB = Task.Factory.StartNew(AddValue);
            var tasks = new[] { taskA, taskB };
            Task.WaitAll(tasks);
            Console.WriteLine("Lock Complete");
        }

        private void AddValue()
        {
            var stopWatch = Stopwatch.StartNew();
            while (stopWatch.ElapsedMilliseconds < 5000)
            {
                lock (_lockObject)
                {
                    _value++;
                    Console.WriteLine("Value is {0} by Thread {1}", _value, Thread.CurrentThread.ManagedThreadId);
                    Thread.Sleep(500);
                }
            }
        }
    }
}
