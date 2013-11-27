using System;
using System.Runtime.Serialization;
using System.Security.Permissions;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.Exceptions.ExceptionThrowing
{
    public class CustomExceptionCommand : DemoCommand
    {
        public CustomExceptionCommand()
        {
            AddResource("The correct way to code a custom exception class", "http://blogs.msdn.com/b/agileer/archive/2013/05/17/the-right-way-to-write-a-custom-exception-class.aspx");
            AddResource("Designing Custom Exceptions", "http://msdn.microsoft.com/en-us/library/vstudio/ms229064(v=vs.100).aspx");
        }

        public override string Description
        {
            get { return "Custom Exceptions"; }
        }

        public override void ExecuteDemo()
        {
            try
            {                
                throw new MyCustomException("Message");
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine("Caught {0}", ex.Message);
            }            
        }
    }

    [Serializable]
    public class MyCustomException : Exception
    {
        public MyCustomException()
        {
        }

        public MyCustomException(string message)
            : base(message)
        {
        }

        public MyCustomException(string message, Exception inner)
            : base(message, inner)
        {
        }

        #region Serialization
        public string ResourceReferenceProperty { get; set; }

        protected MyCustomException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            ResourceReferenceProperty = info.GetString("ResourceReferenceProperty");
        }
 
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");
            info.AddValue("ResourceReferenceProperty", ResourceReferenceProperty);
            base.GetObjectData(info, context);
        }

        #endregion
    }
}
