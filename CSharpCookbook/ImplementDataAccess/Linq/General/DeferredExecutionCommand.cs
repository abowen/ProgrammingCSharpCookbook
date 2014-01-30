using System;
using System.Collections.Generic;
using System.Linq;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ImplementDataAccess.Linq.General
{
    public class DeferredExecutionCommand : DemoCommand
    {
        public DeferredExecutionCommand()
        {
            AddResource("LINQ", "C# In A NutShell, Location 14547");
        }

        public override string Description
        {
            get { return "Deferred Execution"; }
        }

        public override void ExecuteDemo()
        {
            var numbers = new List<int>();
            var value1 = 1;
            numbers.Add(1);
            Console.WriteLine("Added {0}", value1);
            var query = numbers.Select(n => n*10);
            Console.WriteLine("Query against List");
            var value2 = 2;
            numbers.Add(2);
            Console.WriteLine("Added {0}", value2);

            Console.WriteLine("Evaluation");
            PrintNumbers(query);
            Console.WriteLine("Clear List (query left ignored)");
            numbers.Clear();
            Console.WriteLine("Re-evaluation");
            PrintNumbers(query);
        }

        private static void PrintNumbers(IEnumerable<int> query)
        {
            if (!query.Any())
            {
                Console.WriteLine("No Values");
            }
            foreach (var value in query)
            {
                Console.WriteLine("Value * 10: {0}", value);
            }
        }
    }
}

