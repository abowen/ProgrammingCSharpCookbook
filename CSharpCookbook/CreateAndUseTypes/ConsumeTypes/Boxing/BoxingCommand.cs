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
            WorkingDemo();
            NotWorkingDemo();
        }

        private static void WorkingDemo()
        {
            Console.WriteLine("Working Example");
            var value = 123;
            object boxValue = value;
            Console.WriteLine("Normal Integer Value {0}  Hashcode {1}", value, value.GetHashCode());
            Console.WriteLine("Boxxed Integer Value {0}  Hashcode {1}", boxValue, boxValue.GetHashCode());
            boxValue = 456;
            Console.WriteLine("Normal Integer Value {0}  Hashcode {1}", value, value.GetHashCode());
            Console.WriteLine("Boxxed Integer Value {0}  Hashcode {1}", boxValue, boxValue.GetHashCode());
            Console.WriteLine();
        }

        private static void NotWorkingDemo()
        {
            try
            {
                Console.WriteLine("Convert From Int -> Object -> Long");
                int value = 123;
                object boxValue = (object)value;
                long unboxValue = (long)boxValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught Exception: {0}", ex.GetType());
            }
            Console.WriteLine();
        }
    }    
}
