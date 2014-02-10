using System;
using System.Collections.Generic;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ProgramFlow.Expressions
{
    public class AdvancedExpressionCommand : DemoCommand
    {
        public AdvancedExpressionCommand()
        {
            //AddResource("Expressions", "http://msdn.microsoft.com/en-us/library/ms173144.aspx");
            //AddResource("Expressions and Operators", "C# in a NutShell, Location 2898");
        }

        public override string Description
        {
            get { return "Advanced Expressions"; }
        }

        public override void ExecuteDemo()
        {
            var result = 10;
            result *= 5 + 9 / 3;
            var expression = @"10 *= 5 + 9 / 3";
            Console.WriteLine("Expression : {0}", expression);
            Console.WriteLine("Result     : {0}", result);            
        }
    }
}

