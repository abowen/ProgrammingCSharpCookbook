using CSharpCookbook.BaseCommands;
using CSharpCookbook.ImplementDataAccess.Linq;

namespace CSharpCookbook.ImplementDataAccess
{
    public class ImplementDataAccessCommand : DisplayCommand
    {
        public override string Description { get { return "Implement Data Access"; } }

        public ImplementDataAccessCommand()
        {
            AddCommand(new LinqCommand());
        }
    }
}
