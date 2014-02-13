using CSharpCookbook.BaseCommands;
using CSharpCookbook.ImplementDataAccess.Linq;
using CSharpCookbook.ImplementDataAccess.LinqOperators;
using CSharpCookbook.ImplementDataAccess.Mapping;

namespace CSharpCookbook.ImplementDataAccess
{
    public class ImplementDataAccessCommand : DisplayCommand
    {
        public override string Description { get { return "Implement Data Access"; } }

        public ImplementDataAccessCommand()
        {
            AddCommand(new LinqCommand());
            AddCommand(new LinqOperatorsCommand());
            AddCommand(new MappingCommand());
        }
    }
}
