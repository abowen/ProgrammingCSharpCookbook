using System;
using System.Collections;
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
            StructExample();
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

        private static void StructExample()
        {
            Console.WriteLine("Array");
            object[] a1 = { "string", 123, true };
            object[] a2 = { "string", 123, true };            
            Console.WriteLine("==      : {0}", a1 == a2);
            Console.WriteLine(".Equals : {0}", a1.Equals(a2));
            IStructuralEquatable se1 = a1;
            var result = se1.Equals(a2, StructuralComparisons.StructuralEqualityComparer);
            Console.WriteLine("ISE     : {0}", result);
        }
    }    
}
