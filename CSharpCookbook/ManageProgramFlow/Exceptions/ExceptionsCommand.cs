using CSharpCookbook.BaseCommands;
using CSharpCookbook.ManageProgramFlow.Exceptions.ExceptionHandling;

namespace CSharpCookbook.ManageProgramFlow.Exceptions
{
    public class ExceptionsCommand: DisplayCommand
    {
        public override string Description
        {
            get { return "Exceptions"; }
        }

        public ExceptionsCommand()
        {
            AddCommand(new DivideByZeroExceptionCommand());
            AddCommand(new TryCatchFinallyCommand());            
        }
    }
}
