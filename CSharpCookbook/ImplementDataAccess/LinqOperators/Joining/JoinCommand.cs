using System;
using System.Collections.Generic;
using System.Linq;
using CSharpCookbook.BaseCommands;
using CSharpCookbook.SqlFu;

namespace CSharpCookbook.ImplementDataAccess.LinqOperators.Joining
{
    public class JoinCommand : DemoCommand
    {
        public JoinCommand()
        {
            AddResource("Join", "C# In A NutShell, Location 17136");
        }

        public override string Description
        {
            get { return "Join"; }
        }

        public override void ExecuteDemo()
        {
            var repository = new MySqlFu();
            _persons = repository.QueryPerson();
            _purchases = repository.QueryPurchase();

            QuerySyntax();
            FluentSyntax();
        }

        private IEnumerable<Person> _persons;
        private IEnumerable<Purchase> _purchases;

        private void QuerySyntax()
        {
            Console.WriteLine("Query Syntax");
            var query = from person in _persons
                        join purchase in _purchases on person.Id equals purchase.PersonId
                        select new { person, purchase};

            query.ToList().ForEach((obj => Console.WriteLine("{0} paid {1}", obj.person.FirstName, obj.purchase.Price)));
            Console.WriteLine();
        }

        private void FluentSyntax()
        {
            Console.WriteLine("Fluent Syntax");
            var query = _persons.Join(_purchases,
                person => person.Id,
                purchase => purchase.PersonId,
                (person, purchase) => new { person, purchase });

            query.ToList().ForEach((obj => Console.WriteLine("{0} paid {1}", obj.person.FirstName, obj.purchase.Price)));
            Console.WriteLine();
        }
    }
}

