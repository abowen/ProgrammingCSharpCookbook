using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CSharpCookbook.Interfaces;

namespace CSharpCookbook.ManageProgramFlow.Asynchronous.ParallelFor
{
    public class ParallelForCancelCommand : ICommand, IMsdn
    {
        public string Description { get { return ""; } }

        public void Execute()
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


        public string Website { get { return "http://msdn.microsoft.com/en-us/library/ee256691%28v=vs.110%29.aspx"; } }
        public string Title { get { return "Cancel a Parallel.For or ForEach Loop"; } }
    }
}
