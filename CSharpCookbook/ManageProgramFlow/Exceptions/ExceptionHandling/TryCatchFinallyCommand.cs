using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.Exceptions.ExceptionHandling
{
    public class TryCatchFinallyCommand : DemoCommand
    {
        public TryCatchFinallyCommand()
        {
            AddResource("try-catch-finally", "http://msdn.microsoft.com/en-us/library/dszsf989.aspx");            
        }

        public override string Description
        {
            get { return "Try-Catch-Finally"; }
        }               

        public override void ExecuteDemo()
        {
            TryCatchFinallyMethod(false);
            TryCatchFinallyMethod(true);
        }

        public void TryCatchFinallyMethod(bool throwException)
        {
            Console.WriteLine("Will Exception Be Thrown: {0}", throwException);
            try
            {
                Console.WriteLine("Try");
                ThrowException(throwException);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught");                
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }

        public void ThrowException(bool throwException)
        {
            if (throwException)
            {
                throw new Exception("Exception");
            }            
        }        
    }
}
