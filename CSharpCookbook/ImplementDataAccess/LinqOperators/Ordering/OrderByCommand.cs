using System;
using System.Linq;
using CSharpCookbook.BaseCommands;
using CSharpCookbook.SqlFu;

namespace CSharpCookbook.ImplementDataAccess.LinqOperators.Ordering
{
    public class OrderByCommand : DemoCommand
    {
        public OrderByCommand()
        {
            AddResource("LINQ", "C# In A NutShell, Location 17367");
        }

        public override string Description
        {
            get { return "OrderBy & ThenBy"; }
        }

        public override void ExecuteDemo()
        {
            var repository = new MySqlFu();
            Console.WriteLine("OrderBy");
            var peopleOrderBy = repository.QueryPerson().OrderBy(f => f.LastName).Take(5);
            peopleOrderBy.ToList().ForEach(Console.WriteLine);

            // ThenBy requires an IOrderedEnumerable
            Console.WriteLine("ThenBy");
            var peopleThenBy = repository.QueryPerson().OrderBy(f => f.LastName).ThenBy(f => f.FirstName).Take(5);
            peopleThenBy.ToList().ForEach(Console.WriteLine);
        }        
    }
}

