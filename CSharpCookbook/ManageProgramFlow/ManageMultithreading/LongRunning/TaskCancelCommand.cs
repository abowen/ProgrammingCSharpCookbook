using System;
using System.Threading;
using System.Threading.Tasks;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ManageMultithreading.LongRunning
{
    public class TaskCancelCommand : DemoCommand
    {
        public TaskCancelCommand()
        {
            AddResource("Task Cancellation", "http://msdn.microsoft.com/en-us/library/dd997396.aspx");
        }

        public override string Description { get { return "Task Cancellation"; } }
        public override void ExecuteDemo()
        {            
            var task = Task.Factory.StartNew(Calculate);

            var cancelSource = new CancellationTokenSource();
            var keyboardListener = new KeyboardListener();
            keyboardListener.Cancel(cancelSource);
            
            Console.WriteLine("Waiting for Task");
            try
            {
                task.Wait(cancelSource.Token);
            }
            catch (Exception)
            {                
                Console.WriteLine("Exception from cancel caught");                
            }            
        }

        private static void Calculate()
        {
            Console.WriteLine("Extremely long process started");
            Thread.Sleep(int.MaxValue);
            Console.WriteLine("Extremely long process completed");
        }
    }
}
