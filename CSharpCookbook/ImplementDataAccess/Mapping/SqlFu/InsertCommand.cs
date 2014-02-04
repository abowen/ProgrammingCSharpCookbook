using System;
using System.Linq;
using CSharpCookbook.BaseCommands;
using CSharpCookbook.SqlFu;

namespace CSharpCookbook.ImplementDataAccess.Mapping.SqlFu
{
    public class InsertCommand : DemoCommand
    {
        public InsertCommand()
        {
            AddResource("Sql Fu", @"https://github.com/sapiens/SqlFu");
        }

        public override string Description
        {
            get { return "SQL Fu - Insert"; }
        }

        public override void ExecuteDemo()
        {            
            var mySqlFu = new MySqlFu();
            Console.Write("First Name: ");
            var firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            var lastName = Console.ReadLine();
            mySqlFu.InsertPerson(firstName, lastName);
        }
    }
}

