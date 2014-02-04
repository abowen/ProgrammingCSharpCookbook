using CSharpCookbook.BaseCommands;
using CSharpCookbook.ImplementDataAccess.Mapping.SqlFu;

namespace CSharpCookbook.ImplementDataAccess.Mapping
{
    public class MappingCommand : DisplayCommand
    {
        public override string Description
        {
            get { return "ORM"; }
        }

        public MappingCommand()
        {
            AddCommand(new TestCommand());
            AddCommand(new QueryCommand());
            AddCommand(new InsertCommand());
        }
    }
}