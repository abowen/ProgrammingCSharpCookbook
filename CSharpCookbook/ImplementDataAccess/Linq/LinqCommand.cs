using CSharpCookbook.BaseCommands;
using CSharpCookbook.ImplementDataAccess.Linq.General;
using CSharpCookbook.ImplementDataAccess.Linq.Queryable;

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
            AddCommand(new ChainingCommand());
            AddCommand(new DeferredExecutionCommand());
            AddCommand(new IntoCommand());            
            AddCommand(new LetCommand());
            AddCommand(new LinqToSqlCommand());
            AddCommand(new JoinPerformanceCommand());
        }
    }
}