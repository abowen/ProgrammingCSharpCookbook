using System;
using System.Linq;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ImplementDataAccess.Linq.Operators
{
    public class WhereCommand : DemoCommand
    {
        public WhereCommand()
        {
            AddResource("LINQ", "C# In A NutShell, Location 14136");
        }

        public override string Description
        {
            get { return "Where"; }
        }

        public override void ExecuteDemo()
        {
            FluentSyntaxDemo();
            QueryExpressionDemo();
        }

        private string[] _names = new[] {"Andrew", "James", "Bowen"};

        private void FluentSyntaxDemo()
        {
            var startsWithA = _names.Where(n => n.StartsWith("A"));
            Console.WriteLine("Fluent {0}", startsWithA.Count());
        }

        private void QueryExpressionDemo()
        {
            var startsWithA = 
                from name in _names
                where name.StartsWith("A")
                select name;
            Console.WriteLine("Query {0}", startsWithA.Count());
        }
    }
}

