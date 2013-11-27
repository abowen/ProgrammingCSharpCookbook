using System;
using System.Runtime.Serialization;
using System.Security.Permissions;
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
            try
            {
                Console.WriteLine("Keep Stack");
                EntryMethod(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception stack trace {0}", ex.StackTrace);
            }

            try
            {
                Console.WriteLine("Don't Keep Stack");
                EntryMethod(false);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception stack trace {0}", ex.StackTrace);
            }                        
        }

        public void EntryMethod(bool keepStack)
        {
            try
            {
                ExceptionMethod();
            }
            catch (Exception ex)
            {
                if (keepStack)
                {                    
                    throw;
                }
                else
                {                    
                    throw ex;
                }
            }
        }

        public void ExceptionMethod()
        {
            throw new Exception("Original");
        }
    }    
}
