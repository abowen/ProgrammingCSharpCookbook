using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.Exceptions.ExceptionHandling
{
    public class DivideByZeroExceptionCommand : DemoCommand
    {
        public DivideByZeroExceptionCommand()
        {
            //AddResource("Exception Class", "http://msdn.microsoft.com/en-us/library/system.exception%28v=vs.110%29.aspx");
            //AddResource("Handling and Throwing Exceptions", "http://msdn.microsoft.com/en-us/library/5b2yeyab%28v=vs.110%29.aspx");
            AddResource("DivideByZeroException", "http://msdn.microsoft.com/en-us/library/system.dividebyzeroexception%28v=vs.110%29.aspx");
        }

        public override string Description
        {
            get { return "DivideByZero Exception"; }
        }               

        public override void ExecuteDemo()
        {            
            try
            {
                var zero = 0;
                var value = 5/zero;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException Caught");                
            }
        }

        
    }
}
