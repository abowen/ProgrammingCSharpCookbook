using System;
using System.Linq.Expressions;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ProgramFlow.Expressions
{
    public class ExpressionTreeCommand : DemoCommand
    {
        public ExpressionTreeCommand()
        {
            AddResource("Expression Trees", "http://msdn.microsoft.com/en-us/library/vstudio/bb397951.aspx");
        }

        public override string Description
        {
            get { return "Expression Tree"; }
        }

        delegate int MyDelegate(int i);

        public override void ExecuteDemo()
        {            
            Expression<MyDelegate> expression = x => x * x;            
            var value = expression.Compile().Invoke(5);
            Console.WriteLine("Using Delegate: {0}", value);            
            
            Expression<Func<int, bool>> lambda = num => num < 5;
            var isTrue = lambda.Compile()(5);
            Console.WriteLine("Using Func: {0}", isTrue);            
        }
    }
}

