using System;
using CSharpCookbook.BaseCommands;
using CSharpCookbook.SqlFu;

namespace CSharpCookbook.ImplementDataAccess.Mapping.SqlFu
{
    public class TestCommand : DemoCommand
    {
        public TestCommand()
        {
            AddResource("Sql Fu", @"https://github.com/sapiens/SqlFu");
        }

        public override string Description
        {
            get { return "SQL Fu - Test Connection"; }
        }

        public override void ExecuteDemo()
        {
            var mySqlFu = new MySqlFu();
            Console.WriteLine("Connection: {0}", mySqlFu.TestConnection());
        }
    }
}

