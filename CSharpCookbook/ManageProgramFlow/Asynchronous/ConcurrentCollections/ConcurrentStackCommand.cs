using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.Asynchronous.ConcurrentCollections
{
    public class ConcurrentStackCommand : DemoCommand
    {
        public ConcurrentStackCommand()
        {
            AddResource("Thread Safe Collections", "http://msdn.microsoft.com/en-us/library/dd997305.aspx");
            AddResource("Concurrent Stack Class", "http://msdn.microsoft.com/en-us/library/dd267331.aspx");
        }

        public override string Description
        {
            get { return "Concurrent Stack"; }
        }

        private readonly ConcurrentStack<int> _concurrentStack = new ConcurrentStack<int>();

        public override void ExecuteDemo()
        {
            Parallel.For(0, 5, (i, state) => Task.Factory.StartNew(AddValues));
            Thread.Sleep(1000);
            if (_concurrentStack.Count() == 25)
            {
                Console.WriteLine("Matches");
            }
            else
            {
                throw new Exception("Error on Stack");
            }
        }

        private void AddValues()
        {
            var range = Enumerable.Range(0, 5).ToList();
            foreach (var value in range)
            {
                _concurrentStack.Push(value);    
            }            
        }
    }
}
