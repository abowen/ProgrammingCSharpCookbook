using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ProgramFlow.Iteration
{
    public class ArrayForEachCommand : DemoCommand
    {
        public ArrayForEachCommand()
        {
            AddResource("Array.ForEach", "http://msdn.microsoft.com/en-us/library/zecdkyw2%28v=vs.110%29.aspx");
        }

        public override string Description
        {
            get { return "Array ForEach"; }
        }

        public override void ExecuteDemo()
        {
            var arrayItems = new[] { 1, 2, 3 };
            Array.ForEach(arrayItems, i => Console.WriteLine("Array {0}", i));
        }
    }
}
