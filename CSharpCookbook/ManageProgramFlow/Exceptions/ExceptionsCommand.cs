using CSharpCookbook.BaseCommands;
using CSharpCookbook.ManageProgramFlow.Exceptions.ExceptionHandling;
using CSharpCookbook.ManageProgramFlow.Exceptions.ExceptionThrowing;

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
            AddCommand(new CatchTypedCommand());
            AddCommand(new CustomExceptionCommand());
            AddCommand(new RethrowCommand());            
        }
    }
}
