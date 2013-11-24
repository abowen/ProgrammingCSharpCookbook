using System;
using System.Collections.Concurrent;
using System.Linq;
using CSharpCookbook.Interfaces;

namespace CSharpCookbook.ManageProgramFlow.PLINQ
{
    public class ForAllCommand : ICommand, IMsdn
    {
        public string Description { get { return "ParallelQuery.ForAll"; } }

        /// <summary>
        /// Allows the Calculate method to begin even before the Process methods have finished
        /// i.e. Process result sequence in parallel
        /// </summary>
        public void Execute()
        {            
            var values = Enumerable.Range(0, 20).ToArray();

            var concurrentList = new ConcurrentQueue<double>();

            ParallelQuery<double> processedValues = values.AsParallel().Select(Process);
            processedValues.ForAll(value => concurrentList.Enqueue(Calculate(value)));
        }

        private static double Process(int value)
        {
            Console.WriteLine("ForAll Process: {0}", value);
            return Math.Sqrt(value);
        }

        private static double Calculate(double value)
        {
            Console.WriteLine("ForAll Calculate: {0}", value);
            return Math.Sqrt(value);
        }

        public string Title { get { return "The ForAll Operator"; } }
        public string Website { get { return "http://msdn.microsoft.com/en-us/library/dd997425.aspx"; } }        
    }
}
