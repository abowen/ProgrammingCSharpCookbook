using System;
using System.Collections.Concurrent;
using System.Linq;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.Asynchronous.PLINQ
{
    public class ForAllCommand : DemoCommand
    {
        public ForAllCommand()
        {
            AddResource("The ForAll Operator", "http://msdn.microsoft.com/en-us/library/dd997425.aspx");
        }

        public override string Description { get { return "ParallelQuery.ForAll"; } }

        /// <summary>
        /// Allows the Calculate method to begin even before the Process methods have finished
        /// i.e. Process result sequence in parallel
        /// </summary>
        public override void ExecuteDemo()
        {            
            var values = Enumerable.Range(0, 20).ToArray();

            var concurrentList = new ConcurrentQueue<double>();

            var processedValues = values.AsParallel().Select(Process);
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
    }
}
