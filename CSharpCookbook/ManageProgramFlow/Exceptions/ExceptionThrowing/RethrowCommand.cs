using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.Exceptions.ExceptionThrowing
{
    public class RethrowCommand : DemoCommand
    {
        public RethrowCommand()
        {
            AddResource("Rethrow to preserve stack details", "http://msdn.microsoft.com/en-us/library/ms182363(v=vs.80).aspx");
        }

        public override string Description
        {
            get { return "Rethrow Exceptions"; }
        }

        public override void ExecuteDemo()
        {
            MethodA();
        }        

        private void OutputExceptionInfo(Exception ex)
        {
            Console.WriteLine("Exception Dump");
            Console.WriteLine("Source: {0}", ex.Source);
            Console.WriteLine("TargetSite {0}", ex.TargetSite);
            Console.WriteLine("StackTrace {0}", ex.StackTrace);            
        }

        public void MethodA()
        {
            Console.WriteLine();
            try
            {
                Console.WriteLine("Keep Stack");
                MethodB(true);
            }
            catch (Exception ex)
            {
                OutputExceptionInfo(ex);
            }
            Console.WriteLine();
            try
            {
                Console.WriteLine("Don't Keep Stack");
                MethodB(false);
            }
            catch (Exception ex)
            {
                OutputExceptionInfo(ex);
            }
        }

        public void MethodB(bool keepStack)
        {
            try
            {
                MethodC();
            }
            catch (Exception ex)
            {
                if (keepStack)
                {
                    throw;
                }
                throw ex;
            }
        }

        public void MethodC()
        {
            throw new Exception("Original Exception Message");
        }
    }
}
