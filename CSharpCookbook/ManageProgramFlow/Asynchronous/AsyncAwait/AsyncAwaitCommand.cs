using System;
using System.Threading;
using System.Threading.Tasks;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.Asynchronous.AsyncAwait
{
    public class AsyncAwaitCommand : DemoCommand
    {
        public AsyncAwaitCommand()
        {
            AddResource("Async Programming with Async & Await", "http://msdn.microsoft.com/en-us/library/vstudio/hh191443.aspx");
        }

        public override string Description
        {
            get { return "Async"; }
        }

        public override void ExecuteDemo()
        {
            Console.WriteLine("Async Enter");
            StartAsync();
            Console.WriteLine("Async Sleep for 5s");
            Thread.Sleep(5000);
            Console.WriteLine("Async Exit");
        }

        private static async void StartAsync()
        {
            Console.WriteLine("StartAsync Start");
            await Task.Run(() => AsyncProcess());
            Console.WriteLine("StartAsync Completed");
        }

        private static void AsyncProcess()
        {
            Console.WriteLine("AsyncProcess Start");
            var progress = 0;
            while (progress < 100)
            {
                Thread.Sleep(100);
                progress += 5;                
                Console.Write("\r {0:000}%", progress);
            }
            Console.WriteLine();
            Console.WriteLine("AsyncProcess Completed");
        }  
    }
}
