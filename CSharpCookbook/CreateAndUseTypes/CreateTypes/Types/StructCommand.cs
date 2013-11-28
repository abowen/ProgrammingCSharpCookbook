using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.CreateTypes.Types
{
    public class StructCommand : DemoCommand
    {
        public StructCommand()
        {
            AddResource("struct (C# Reference)", @"http://msdn.microsoft.com/en-us/library/ah19swz4%28v=vs.120%29.aspx");
            AddResource("Structs", "http://msdn.microsoft.com/en-us/library/saxz13w4.aspx");
        }

        public override string Description
        {
            get { return "Struct"; }
        }

        public override void ExecuteDemo()
        {
            var structA = new MyCustomStruct { Value = 123 };
            var structB = structA;
            Console.WriteLine("structA HashCode {0}", structA.GetHashCode());
            Console.WriteLine("structB HashCode {0}", structB.GetHashCode());
            Console.WriteLine("structA Value {0}", structA.Value);
            Console.WriteLine("structB Value {0}", structB.Value);
            Console.WriteLine();
            Console.WriteLine("structB Value Change");
            structB.Value = 789;
            Console.WriteLine("structA HashCode {0}", structA.GetHashCode());
            Console.WriteLine("structB HashCode {0}", structB.GetHashCode());
            Console.WriteLine("structA Value {0}", structA.Value);
            Console.WriteLine("structB Value {0}", structB.Value);
        }
    }

    public struct MyCustomStruct
    {
        public int Value;
    }
}
