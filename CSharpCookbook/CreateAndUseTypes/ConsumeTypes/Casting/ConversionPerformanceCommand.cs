using System;
using System.Runtime.InteropServices;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ConsumeTypes.Casting
{
    public class ConversionPerformanceCommand : DemoCommand
    {
        public ConversionPerformanceCommand()
        {
            AddResource("Rounding real to integral", "C# In A NutShell, Location 10901");
        }

        public override string Description
        {
            get { return "Conversion Performance"; }
        }

        // Cast is optimised for performance and doesn't round
        // Convert is round using the bankers rule

        public override void ExecuteDemo()
        {
            var castValue = (int)Value;
            var convertValue = System.Convert.ToInt32(Value);

            Console.WriteLine("Start Value: {0}", Value);                        
            Console.WriteLine("Cast Value: {0}", castValue);
            Console.WriteLine("Convert Value: {0}", convertValue);

            PerformanceTest(Cast);
            PerformanceTest(Convert);
        }

        private const decimal Value = 3.72432m;

        private void Cast()
        {
#pragma warning disable 0219
            var i = (int) Value;
#pragma warning restore 0219
        }

        private void Convert()
        {
#pragma warning disable 0219
            var i = System.Convert.ToInt32(Value);
#pragma warning restore 0219
        }
    }    
}
