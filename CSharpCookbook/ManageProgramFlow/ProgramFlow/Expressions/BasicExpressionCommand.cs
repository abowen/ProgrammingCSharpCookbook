using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ProgramFlow.Expressions
{
    public class BasicExpressionCommand : DemoCommand
    {
        public BasicExpressionCommand()
        {
            AddResource("Expressions", "http://msdn.microsoft.com/en-us/library/ms173144.aspx");
            AddResource("Expressions and Operators", "C# in a NutShell, Location 2898");
        }

        public override string Description
        {
            get { return "Basic Expressions"; }
        }

        public override void ExecuteDemo()
        {
            Console.WriteLine("Constant Expression {0}", 12);
            const int number = 5;
            Console.WriteLine("Assignment Expression {0}", number);
            Console.WriteLine("Value Expression {0}", 1 + 1);
            Console.WriteLine("Void Invocation Expression");
            Console.WriteLine();
        }
    }
}

