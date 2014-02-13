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
            AddResource("Expression Trees, Location 15969", "C# In A Nutshell");
        }

        public override string Description
        {
            get { return "Expression Tree"; }
        }

        delegate int MyDelegate(int i);

        public override void ExecuteDemo()
        {
            DelegateDemo();
            FuncDemo();
            HandWrittenDemo();
        }

        private void HandWrittenDemo()
        {
            // C# In A NutShell. Start from bottom up
            // Expression<Func<string, bool>> f = s => s.Length < 5;
            ParameterExpression p = Expression.Parameter(typeof(string), "s");
            MemberExpression stringLength = Expression.Property(p, "Length");
            ConstantExpression five = Expression.Constant(5);
            BinaryExpression comparison = Expression.LessThan(stringLength, five);
            Expression<Func<string, bool>> lambda = Expression.Lambda<Func<string, bool>>(comparison, p);
            Func<string, bool> runnable = lambda.Compile();
            Console.WriteLine(runnable("LongWord"));
            Console.WriteLine(runnable("Short"));            
        }

        private static void FuncDemo()
        {
            Expression<Func<int, bool>> lambda = num => num < 5;
            var isTrue = lambda.Compile()(5);
            Console.WriteLine("Using Func: {0}", isTrue);
        }

        private static void DelegateDemo()
        {
            Expression<MyDelegate> expression = x => x*x;
            var value = expression.Compile().Invoke(5);
            Console.WriteLine("Using Delegate: {0}", value);
        }
    }
}

