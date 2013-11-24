using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.Asynchronous.ParallelFor
{
    public class ParallelForCancelCommand : DemoCommand
    {
        public override string Description { get { return "Parallel.For Cancel"; } }

        public ParallelForCancelCommand()
        {
            AddResource("Cancel a Parallel.For or ForEach Loop", "http://msdn.microsoft.com/en-us/library/ee256691%28v=vs.110%29.aspx");
        }

        public override void ExecuteDemo()
        {                        
            var numbers = Enumerable.Range(0, 1000000).ToArray();

            var cancellationTokenSource = new CancellationTokenSource();
            var parallelOptions = new ParallelOptions {CancellationToken = cancellationTokenSource.Token};

            var listener = new KeyboardListener();
            listener.Cancel(cancellationTokenSource);

            try
            {
                Parallel.ForEach(numbers, parallelOptions, ExternalMethod);
                
            }
            catch (OperationCanceledException canceledException)
            {
                Console.WriteLine(canceledException.Message);
            }                        
        }

        private static void ExternalMethod(int i)
        {
            Console.WriteLine("Sinh: {0} {1}", i, Math.Sinh(i));
            Thread.Sleep(1000);            
        }
    }
}
