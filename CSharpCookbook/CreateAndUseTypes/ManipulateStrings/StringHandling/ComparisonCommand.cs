using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ManipulateStrings.StringHandling
{
    public class ComparisonCommand : DemoCommand
    {
        public ComparisonCommand()
        {            
            AddResource("MSDN: String Comparison", "http://msdn.microsoft.com/en-us/library/system.stringcomparison(v=vs.110).aspx");
        }


        public override string Description
        {
            get { return "Comparison"; }
        }

        public override void ExecuteDemo()
        {            
            OrdinalComparison();
        }
        
        private static void OrdinalComparison()
        {
            var strings1 = new[] { "case",  "encyclopædia",  
                            "encyclopædia", "Archæology" };
            var strings2 = new[] { "Case", "encyclopaedia", 
                            "encyclopedia" , "ARCHÆOLOGY" };
            var comparisons = (StringComparison[])Enum.GetValues(typeof(StringComparison));

            Console.WriteLine("Current Culture: {0}", CultureInfo.CurrentCulture.Name);
            for (var ctr = 0; ctr < strings1.Count(); ctr++)
            {
                foreach (var comparison in comparisons)
                {
                    Console.WriteLine("   {0} = {1} ({2}): {3}", strings1[ctr],
                                      strings2[ctr], comparison,
                                      String.Equals(strings1[ctr], strings2[ctr], comparison));
                }

                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
