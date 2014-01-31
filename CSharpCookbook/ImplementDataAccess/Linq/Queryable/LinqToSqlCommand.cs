using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ImplementDataAccess.Linq.Queryable
{
    public class LinqToSqlCommand : DemoCommand
    {
        public LinqToSqlCommand()
        {
            AddResource("Interpreted Queries", "C# In A NutShell, Location 15004");
        }

        public override string Description
        {
            get { return "LINQ to SQL"; }
        }

        public override void ExecuteDemo()
        {

        }
    }
}

