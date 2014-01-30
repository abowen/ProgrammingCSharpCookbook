using System;
using System.Linq;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ImplementDataAccess.Linq.General
{
    public class ChainingCommand : DemoCommand
    {
        public ChainingCommand()
        {
            AddResource("LINQ", "C# In A NutShell, Location 14404");
        }

        public override string Description
        {
            get { return "Chaining"; }
        }

        public override void ExecuteDemo()
        {
            FluentSyntaxDemo();
            QueryExpressionDemo();
        }

        private readonly string[] _names = {"Andrew", "James", "Bowen", "Thomas", "Michael", "Beth"};

        private void FluentSyntaxDemo()
        {
            var resultSet = _names
                .Where(n => n.Contains("a"))
                .OrderBy(n => n.Length)
                .Select(n => n.ToUpper());

            Console.WriteLine("Fluent {0}", resultSet.Count());
        }

        private void QueryExpressionDemo()
        {
            var resultSet = 
                from name in _names
                where name.Contains("a")
                orderby name.Length
                select name.ToUpperInvariant();

            Console.WriteLine("Query {0}", resultSet.Count());
        }
    }
}

