using System;
using System.Threading.Tasks;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.Asynchronous.ParallelFor
{
    public class ParallelForCommand : DemoCommand
    {
        public override string Description { get { return "Parallel.For"; } }

        public ParallelForCommand()
        {
            AddResource("Write a Simple Parallel.ForEach Loop", "http://msdn.microsoft.com/en-us/library/dd460720%28v=vs.110%29.aspx");
        }

        public override void ExecuteDemo()
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
    }
}
