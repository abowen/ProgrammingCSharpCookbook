using System;
using System.Threading;
using System.Threading.Tasks;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ManageMultithreading.Synchronize
{
    class MutexCommand : DemoCommand
    {
        public MutexCommand()
        {
            AddResource("Mutex Class", "http://msdn.microsoft.com/en-us/library/system.threading.mutex%28v=vs.110%29.aspx");
        }

        public override string Description
        {
            get { return "Mutex"; }
        }

        public override void ExecuteDemo()
        {
            Parallel.For(0, 10, UseResource);                            
        }        

        private static readonly Mutex Mutex = new Mutex();
        
        private static void UseResource(int value)
        {            
            Mutex.WaitOne();
            Console.WriteLine("Mutex Access for {0}", value);
            Thread.Sleep(500);            
            Mutex.ReleaseMutex();
        }
    }
}
