using System;
using System.Threading.Tasks;
using CSharpCookbook.Interfaces;

namespace CSharpCookbook.ManageProgramFlow.ParallelFor
{
    public class ParallelForCommand : ICommand, IMsdn
    {
        public string Description { get { return "Parallel.For"; } }

        public void Execute()
        {
            Console.WriteLine(@"Parallel.For with method");
            Parallel.For(0, 10, ExternalMethod);
            Console.WriteLine(@"Parallel.For with anonymous method");
            Parallel.For(0, 10, squareNumber => Console.WriteLine(squareNumber*squareNumber));            
        }

        private static void ExternalMethod(int i)
        {
            Console.WriteLine("Square Root: {0} is {1}", i, Math.Sqrt(i));
        }

        public string Title { get { return "Write a Simple Parallel.ForEach Loop"; } }
        public string Website { get { return "http://msdn.microsoft.com/en-us/library/dd460720%28v=vs.110%29.aspx"; } }        
    }
}
