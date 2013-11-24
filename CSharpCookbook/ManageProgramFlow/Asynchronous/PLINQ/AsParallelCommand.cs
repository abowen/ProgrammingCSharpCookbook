using System;
using System.Linq;
using CSharpCookbook.Interfaces;

namespace CSharpCookbook.ManageProgramFlow.Asynchronous.PLINQ
{
    public class AsParallelCommand : Command, IMsdn
    {
        public override string Description { get { return "AsParallel"; } }

        public override void ExecuteCommand()
        {            
            var values = Enumerable.Range(0, 10).ToArray();
            var filteredValues = from value in values.AsParallel()
                where value % 2 != 0
                select value;
            var oddOutput = string.Join(",", filteredValues);
            Console.WriteLine(oddOutput);            
        }

        

        public string Title { get { return "Introduction to PLINQ"; } }
        public string Website { get { return "http://msdn.microsoft.com/en-us/library/dd997425.aspx"; } }        
    }
}
