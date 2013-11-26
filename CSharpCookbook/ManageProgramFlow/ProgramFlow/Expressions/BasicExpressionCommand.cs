using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ProgramFlow.Expressions
{
    public class BasicExpressionCommand : DemoCommand
    {
        public BasicExpressionCommand()
        {
            AddResource("Expressions", "http://msdn.microsoft.com/en-us/library/ms173144.aspx");
        }

        public override string Description
        {
            get { return "Basic Expressions"; }
        }

        public override void ExecuteDemo()
        {
            Console.WriteLine("Assignment Expression");
            var number = 5;
            Console.WriteLine(number);
            Console.WriteLine();
            Console.WriteLine("Value Expression");            
            Console.WriteLine("1 + 1 = {0}", 1 + 1);
            Console.WriteLine();
            Console.WriteLine("Invocation Expression");
            SimpleMethod();
            Console.WriteLine();
        }

        private void SimpleMethod()
        {
            Console.WriteLine("-- Code inside method");
        }

    }
}

