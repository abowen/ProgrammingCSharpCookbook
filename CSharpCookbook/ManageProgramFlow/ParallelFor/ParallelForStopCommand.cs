using System;
using System.Threading.Tasks;

namespace CSharpCookbook.ManageProgramFlow.ParallelFor
{
    public class ParallelForStopCommand : ICommand, IMsdn
    {
        public string Description { get { return "Parallel.For Stop"; } }

        public void Execute()
        {
            Console.WriteLine(@"Parallel.For with stop");
            Parallel.For(0, 10, StopMethod);            
        }

        /// <summary>
        /// "Stop" means to stop all iterations as soon as convenient.
        /// </summary>        
        private static void StopMethod(int i, ParallelLoopState parallelLoopState)
        {
            if (i > 5)
            {
                Console.WriteLine("Stop {0}", i);
                parallelLoopState.Stop();
                return;
            }

            Console.WriteLine("Log10: {0} {1}", i, Math.Log10(i));
        }


        public string Title { get { return "Stop or Break from a Parallel.For Loop"; } }
        public string Website { get { return "http://msdn.microsoft.com/en-us/library/dd460721%28v=vs.110%29.aspx"; } }
    }
}
