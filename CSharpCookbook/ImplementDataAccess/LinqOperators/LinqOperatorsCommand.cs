using CSharpCookbook.BaseCommands;
using CSharpCookbook.ImplementDataAccess.Linq.Operators;
using CSharpCookbook.ImplementDataAccess.LinqOperators.Projecting;

namespace CSharpCookbook.ImplementDataAccess.LinqOperators
{
    public class LinqOperatorsCommand : DisplayCommand
    {
        public override string Description
        {
            get { return "LINQ"; }
        }

        public LinqOperatorsCommand()
        {
            AddCommand(new WhereCommand());
            AddCommand(new SelectCommand());            
        }
    }
}