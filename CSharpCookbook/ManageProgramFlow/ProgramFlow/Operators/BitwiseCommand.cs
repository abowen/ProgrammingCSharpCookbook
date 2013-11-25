using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ProgramFlow.Operators
{
    public class BitwiseCommand : DemoCommand
    {
        public BitwiseCommand()
        {
            AddResource("~ Operator", "http://msdn.microsoft.com/en-us/library/d2bd4x66.aspx");
            AddResource("& Operator", "http://msdn.microsoft.com/en-us/library/sbf85k1c.aspx");
            AddResource("^ Operator", "http://msdn.microsoft.com/en-us/library/zkacc7k1.aspx");
            AddResource("<< Resource", "http://msdn.microsoft.com/en-us/library/a1sway8w.aspx");
        }

        public override string Description
        {
            get { return "Bitwise"; }
        }

        public override void ExecuteDemo()
        {
            Console.WriteLine("Complement");
            var value = 0x22000022;            
            Console.WriteLine("~0x{0:x8} = 0x{1:x8}", value, ~value);

            Console.WriteLine("And");
            var valueA = 0xf8;
            var valueB = 0x3f;
            Console.WriteLine("{0} AND {1} = 0x{2:x}", valueA, valueB,  valueA & valueB );

            Console.WriteLine("Or");
            Console.WriteLine("{0} OR {1} = 0x{2:x}", valueA, valueB, valueA | valueB);

            Console.WriteLine("Exclusive Or");
            Console.WriteLine("{0} XOR {1} = 0x{2:x}", valueA, valueB, valueA ^ valueB);

            Console.WriteLine("Shift Operator");                        
            Console.WriteLine("{0:x8} << 1 = 0x{1:x8}", value, value << 1);
        }
    }
}
