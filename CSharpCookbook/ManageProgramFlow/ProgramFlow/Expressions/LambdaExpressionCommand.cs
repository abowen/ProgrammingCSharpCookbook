using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ProgramFlow.Expressions
{
    public class LambdaExpressionCommand : DemoCommand
    {
        public LambdaExpressionCommand()
        {
            AddResource("Lambda Expressions", "http://msdn.microsoft.com/en-us/library/bb397676.aspx");
        }

        public override string Description
        {
            get { return "Lambda Expression"; }
        }

        delegate int CustomDelegate(int i);

        public override void ExecuteDemo()
        {
            CustomDelegate customDelegate = x => x * x;
            Console.WriteLine("Delegate {0} is {1}", 5, customDelegate(5)); 
        }
    }
}

