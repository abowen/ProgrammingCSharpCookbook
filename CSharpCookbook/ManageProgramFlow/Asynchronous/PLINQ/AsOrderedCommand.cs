using System;
using System.Linq;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.Asynchronous.PLINQ
{
    public class AsOrderedCommand : DemoCommand
    {
        public AsOrderedCommand()
        {
            AddResource("Introduction to PLINQ", "http://msdn.microsoft.com/en-us/library/dd997425.aspx");
        }

        public override string Description { get { return "AsOrdered"; } }

        public override void ExecuteDemo()
        {            
            var values = Enumerable.Range(0, 10).ToArray();

            var filteredValues = from value in values.AsParallel().AsOrdered()
                where value%2 == 0
                select value;

            var output = string.Join(",", filteredValues);
            Console.WriteLine(output);
        }
    }
}
