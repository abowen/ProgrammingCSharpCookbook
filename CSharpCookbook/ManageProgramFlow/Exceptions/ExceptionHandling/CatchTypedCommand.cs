using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.Exceptions.ExceptionHandling
{
    public class CatchTypedCommand : DemoCommand
    {
        public CatchTypedCommand()
        {
            AddResource("Using Exceptions", "http://msdn.microsoft.com/en-us/library/ms173161(v=vs.110).aspx");            
        }

        public override string Description
        {
            get { return "Catch Typed"; }
        }               

        public override void ExecuteDemo()
        {
            TryCatchMethod(false);
            TryCatchMethod(true);
        }

        public void TryCatchMethod(bool throwSpecificException)
        {
            Console.WriteLine("Will Specific Exception Be Thrown: {0}", throwSpecificException);
            try
            {                
                ThrowException(throwSpecificException);
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine("Caught {0}", ex.GetType());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught {0}", ex.GetType());
            }            
        }

        public void ThrowException(bool throwSpecificException)
        {
            if (throwSpecificException)
            {
                throw new ApplicationException();
                
            }
            throw new Exception();
        }        
    }
}
