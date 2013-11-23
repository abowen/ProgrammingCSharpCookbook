using System;
using System.Linq;

namespace CSharpCookbook.ManageProgramFlow.PLINQ
{
    public class AsParallelCommand : ICommand, IMsdn
    {
        public string Description { get { return "AsParallel"; } }

        public void Execute()
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
