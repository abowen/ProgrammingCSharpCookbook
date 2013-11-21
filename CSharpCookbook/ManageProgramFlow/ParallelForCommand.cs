using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpCookbook.ManageProgramFlow
{
    public class ParallelForCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine(@"Parallel.For(0, 15, SquareValue);");
            Parallel.For(0, 15, squareNumber => Console.WriteLine(squareNumber * squareNumber));
            var numbers = new[] {1, 2, 3, 4, 5};
            var options = new ParallelOptions();
            var cancellationToken = new CancellationToken(true);
            options.CancellationToken = cancellationToken;

            Parallel.ForEach(numbers, options, Body);
            
            
            
        }

        private void Body(int i, ParallelLoopState state)
        {
            for (int index = 1; index<=i; index++)
            {
                var output = String.Format("QUIT to stop - {0} of {1}", index, i);
                Console.WriteLine(output);                
                var readline = Console.ReadLine();
                if (readline == "QUIT")
                {                    
                    output = String.Format("QUITTING - {0} of {1}", index, i);
                    Console.WriteLine(output);
                    state.Break();
                }
            }
        }        
    }
}
