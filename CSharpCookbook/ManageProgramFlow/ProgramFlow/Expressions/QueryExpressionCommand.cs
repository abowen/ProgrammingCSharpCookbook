using System;
using System.Linq;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ProgramFlow.Expressions
{
    public class QueryExpressionCommand : DemoCommand
    {
        public QueryExpressionCommand()
        {
            AddResource("LINQ Query Expressions", "http://msdn.microsoft.com/en-us/library/bb397676.aspx");
        }

        public override string Description
        {
            get { return "Query Expression"; }
        }

        public override void ExecuteDemo()
        {            
            var filteredNumbers =
                from number in Enumerable.Range(0, 100)
                where number % 11 == 0
                select number;

            var output = string.Join(",", filteredNumbers);
            Console.WriteLine("Numbers divisible by 11: {0}", output);
        }
    }
}

