using System;
using System.Linq;
using CSharpCookbook.BaseCommands;
using CSharpCookbook.SqlFu;

namespace CSharpCookbook.ImplementDataAccess.Mapping.SqlFu
{
    public class QueryCommand : DemoCommand
    {
        public QueryCommand()
        {
            AddResource("Sql Fu", @"https://github.com/sapiens/SqlFu");
        }

        public override string Description
        {
            get { return "SQL Fu - Query"; }
        }

        public override void ExecuteDemo()
        {
            Console.WriteLine("People with first name Andrew");

            var mySqlFu = new MySqlFu();
            var andrewLastNames =
                from person in mySqlFu.QueryPerson()
                where person.FirstName == "Andrew"
                select person.LastName;
            andrewLastNames.ToList().ForEach(Console.WriteLine);
        }
    }
}

