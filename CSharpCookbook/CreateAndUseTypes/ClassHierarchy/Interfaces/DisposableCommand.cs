using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ClassHierarchy.Interfaces
{
    public class DispoableCommand : DemoCommand
    {
        public DispoableCommand()
        {
            AddResource("IDisposable Interface", "http://msdn.microsoft.com/en-us/library/system.idisposable%28v=vs.110%29.aspx");
            AddResource("using Statement", "http://msdn.microsoft.com/en-us/library/yh598w02%28v=vs.110%29.aspx");
        }

        public override string Description
        {
            get { return "IDisposable"; }
        }

        public override void ExecuteDemo()
        {
            Console.WriteLine("A - using");
            using (var myDisposableClassA = new MyDisposableClass())
            {
                myDisposableClassA.MyMethod();
            }
            Console.WriteLine("B - try/catch/finally");
            var myDisposableClassB = new MyDisposableClass();
            try
            {
                myDisposableClassB.MyMethod();
                myDisposableClassB.MyExceptionMethod();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught exception: {0}", ex.Message);
            }
            finally
            {
                if (myDisposableClassB != null)
                {
                    myDisposableClassB.Dispose();
                }
            }
        }

        public class MyDisposableClass : IDisposable
        {
            public void MyMethod()
            {
                Console.WriteLine("MyMethod");
            }

            public void MyExceptionMethod()
            {                
                throw new Exception("Exception");
            }

            public void Dispose()
            {
                Console.WriteLine("Disposed");
            }
        }
    }
}

