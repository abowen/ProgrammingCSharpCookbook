using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ConsumeTypes.Boxing
{
    public class BoxingCommand : DemoCommand
    {
        public BoxingCommand()
        {
            AddResource("Boxing and Unboxing", "http://msdn.microsoft.com/en-us/library/yz2be5wk(v=vs.120).aspx");
        }

        public override string Description
        {
            get { return "Boxing and Unboxing"; }
        }

        public override void ExecuteDemo()
        {
            var value = 123;
            object boxValue = value;
            Console.WriteLine("Normal Integer Value {0}  Hashcode {1}", value, value.GetHashCode());
            Console.WriteLine("Boxxed Integer Value {0} Hashcode {1}", boxValue, boxValue.GetHashCode());            
            boxValue = 456;
            Console.WriteLine("Normal Integer Value {0}  Hashcode {1}", value, value.GetHashCode());
            Console.WriteLine("Boxxed Integer Value {0}  Hashcode {1}", boxValue, boxValue.GetHashCode());            
        }
    }    
}
