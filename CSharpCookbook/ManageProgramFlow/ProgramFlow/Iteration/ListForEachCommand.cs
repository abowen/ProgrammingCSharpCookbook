using System;
using System.Collections.Generic;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ProgramFlow.Iteration
{
    public class ListForEachCommand : DemoCommand
    {
        public ListForEachCommand()
        {
            AddResource("List<T>.ForEach Method", "http://msdn.microsoft.com/en-us/library/bwabdf9z%28v=vs.110%29.aspx");
        }

        public override string Description
        {
            get { return "List ForEach"; }
        }

        public override void ExecuteDemo()
        {
            var listItems = new List<int> { 1, 2, 3 };
            listItems.ForEach(i => Console.WriteLine("List {0}", i));
        }
    }
}
