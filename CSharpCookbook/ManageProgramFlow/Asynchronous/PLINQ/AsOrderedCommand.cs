using System;
using System.Linq;
using CSharpCookbook.Interfaces;

namespace CSharpCookbook.ManageProgramFlow.Asynchronous.PLINQ
{
    public class AsOrderedCommand : ICommand, IMsdn
    {
        public string Description { get { return "AsOrdered"; } }

        public void Execute()
        {            
            var values = Enumerable.Range(0, 10).ToArray();

            var filteredValues = from value in values.AsParallel().AsOrdered()
                where value%2 == 0
                select value;

            var output = string.Join(",", filteredValues);
            Console.WriteLine(output);
        }

        

        public string Title { get { return "Introduction to PLINQ"; } }
        public string Website { get { return "http://msdn.microsoft.com/en-us/library/dd997425.aspx"; } }        
    }
}
