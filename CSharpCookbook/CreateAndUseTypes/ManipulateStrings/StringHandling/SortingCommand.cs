using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ManipulateStrings.StringHandling
{
    public class SortingCommand : DemoCommand
    {
        public SortingCommand()
        {
            AddResource("String Order Comparison", "C# In A NutShell, Location 208/1009");            
        }


        public override string Description
        {
            get { return "Sorting"; }
        }

        public override void ExecuteDemo()
        {
            CultureSorting();            
        }

        private static void CultureSorting()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            var items = new List<string> { "Apple", "Æble", "Zebra" };

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine(Thread.CurrentThread.CurrentCulture);
            items.Sort();
            items.ForEach(Console.WriteLine);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("da-DK");
            Console.WriteLine(Thread.CurrentThread.CurrentCulture);
            items.Sort();
            items.ForEach(Console.WriteLine);

            Thread.CurrentThread.CurrentCulture = prevCulture;
        }    
    }
}
