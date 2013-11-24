using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpCookbook
{
    public class KeyboardListener
    {
        public void Cancel(CancellationTokenSource cancellationTokenSource)
        {            
            Task.Factory.StartNew(() =>
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Press 'c' to exit");
                Console.WriteLine("------------------");                
                if (Console.ReadKey().KeyChar == 'c')
                {
                    cancellationTokenSource.Cancel();
                    Console.WriteLine();
                }                
            }, cancellationTokenSource.Token);
        }
    }
}
