using System;
using System.Threading;
using System.Threading.Tasks;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.Asynchronous.ParallelFor
{
    public class ParallelForBreakCommand : DemoCommand
    {
        public ParallelForBreakCommand()
        {
            AddResource("Stop or Break from a Parallel.For Loop", "http://msdn.microsoft.com/en-us/library/dd460721%28v=vs.110%29.aspx");
        }

        public override string Description { get { return "Parallel.For Break"; } }

        public override void ExecuteDemo()
        {                        
            Parallel.For(0, 10, BreakMethod);
        }

        /// <summary>
        /// "Break" means complete all iterations on all threads that are prior to the current iteration on the current thread
        /// </summary>        
        private static void BreakMethod(int i, ParallelLoopState parallelLoopState)
        {
            if (i > 5)
            {
                parallelLoopState.Break();
                Console.WriteLine("Break called: {0} ", i);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Pow: {0} {1}", i, Math.Pow(i, i));
        }
    }
}
