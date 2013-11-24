using System;
using System.Linq;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.Asynchronous.PLINQ
{
    public class AsParallelCommand : DemoCommand
    {
        public AsParallelCommand()
        {
            AddResource("Introduction to PLINQ", "http://msdn.microsoft.com/en-us/library/dd997425.aspx");
        }

        public override string Description { get { return "AsParallel"; } }

        public override void ExecuteDemo()
        {            
            var values = Enumerable.Range(0, 10).ToArray();
            var filteredValues = from value in values.AsParallel()
                where value % 2 != 0
                select value;
            var oddOutput = string.Join(",", filteredValues);
            Console.WriteLine(oddOutput);            
        }
    }
}
