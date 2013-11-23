using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpCookbook.ManageProgramFlow
{
    public class ParallelForBreakCommand : ICommand, IMsdn
    {
        public string Description { get { return "Parallel.For Break"; } }

        public void Execute()
        {
            Console.WriteLine(@"Parallel.For with stop");
            Parallel.For(0, 10, StopMethod);
            Console.WriteLine(@"Parallel.For with break");
            Parallel.For(0, 10, BreakMethod);
        }

        /// <summary>
        /// "Stop" means to stop all iterations as soon as convenient.
        /// </summary>        
        private void StopMethod(int i, ParallelLoopState parallelLoopState)
        {
            if (i > 5)
            {
                Console.WriteLine("Stop {0}", i);
                parallelLoopState.Stop();
                return;
            }

            Console.WriteLine("Log10: {0} {1}", i, Math.Log10(i));
        }

        /// <summary>
        /// "Break" means complete all iterations on all threads that are prior to the current iteration on the current thread
        /// </summary>        
        private void BreakMethod(int i, ParallelLoopState parallelLoopState)
        {
            if (i > 5)
            {
                parallelLoopState.Break();
                Console.WriteLine("Break called: {0} ", i);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Pow: {0} {1}", i, Math.Pow(i, i));
        }


        public string Title { get { return "Stop or Break from a Parallel.For Loop"; } }
        public string Website { get { return "http://msdn.microsoft.com/en-us/library/dd460721%28v=vs.110%29.aspx"; } }
    }
}
