using System;
using System.Collections.Generic;
using System.Linq;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ImplementDataAccess.LinqOperators.Scalar
{
    public class CountCommand : DemoCommand
    {
        public CountCommand()
        {
            AddResource("LINQ", "C# In A NutShell, Location 18001");
        }

        public override string Description
        {
            get { return "Count & LongCount"; }
        }

        public override void ExecuteDemo()
        {            
            Count();
            Console.WriteLine();
            LongCount();            
        }

        private static void Count()
        {
            var total = 1000;
            var count = Enumerable.Range(0, total).Count();
            var longCount = Enumerable.Range(0, total).LongCount();
            Console.WriteLine("Range 0 to {0}", total);
            Console.WriteLine("Count: {0}", count);
            Console.WriteLine("Long Count: {0}", longCount);            
        }

        private static void LongCount()
        {
            try
            {
                // Long count can read up to 2billion but not sure if possible with local query
                var total = 10000000000;
                Console.WriteLine("Range 0 to {0}", total);
                var items = new List<bool>();
                for (double value = 0; value < total; value++)
                {
                    items.Add(true);
                }

                var longCount = items.LongCount();
                Console.WriteLine("Long Count: {0}", longCount);
                var count = items.Count();
                Console.WriteLine("Count: {0}", count);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught Exception: {0}", ex.GetType());
            }
        }
    }
}

