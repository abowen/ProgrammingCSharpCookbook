using CSharpCookbook.BaseCommands;
using CSharpCookbook.ImplementDataAccess.Linq.General;
using CSharpCookbook.ImplementDataAccess.Linq.Operators;

namespace CSharpCookbook.ImplementDataAccess.Linq
{
    public class LinqCommand : DisplayCommand
    {
        public override string Description
        {
            get { return "LINQ"; }
        }

        public LinqCommand()
        {
            AddCommand(new WhereCommand());
            AddCommand(new ProjectionCommand());
            AddCommand(new ChainingCommand());
            AddCommand(new DeferredExecutionCommand());
            AddCommand(new IntoCommand());
        }
    }
}