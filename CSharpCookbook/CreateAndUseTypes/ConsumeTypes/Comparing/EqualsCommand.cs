using System;
using System.Text;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ConsumeTypes.Boxing
{
    public class EqualsCommand : DemoCommand
    {
        public EqualsCommand()
        {
            AddResource("Equals", "C# In A NutShell, Location 11760");
        }

        public override string Description
        {
            get { return "Equals vs =="; }
        }

        public override void ExecuteDemo()
        {
            StringBuilderExample();
            DoubleNaNExample();
        }

        private static void StringBuilderExample()
        {
            var sb1 = new StringBuilder("abc");
            var sb2 = new StringBuilder("abc");
            Console.WriteLine("StringBuilder");
            Console.WriteLine("Reference: {0}", sb1 == sb2);
            Console.WriteLine("Value:     {0}", sb1.Equals(sb2));
        }

        private static void DoubleNaNExample()
        {
            var x = double.NaN;          
            Console.WriteLine("double.NaN");
            Console.WriteLine("==      : {0}", x == double.NaN);
            Console.WriteLine(".Equals : {0}", x.Equals(double.NaN));
            Console.WriteLine(".IsNaN  : {0}", double.IsNaN(x));
        }
    }    
}
