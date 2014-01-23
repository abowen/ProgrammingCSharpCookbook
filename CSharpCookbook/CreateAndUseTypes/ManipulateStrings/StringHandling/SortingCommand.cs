using System;
using System.Collections.Generic;
using System.Globalization;
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
            var americanCulture = new CultureInfo("en-US");
            var danishCulture = new CultureInfo("da-DK");

            CultureTest(SortStrings, Thread.CurrentThread.CurrentCulture);
            CultureTest(SortStrings, americanCulture);
            CultureTest(SortStrings, danishCulture);
        }

        private void SortStrings()
        {
            var items = new List<string> { "Apple", "Æble", "Zebra" };
            items.Sort();
            items.ForEach(Console.WriteLine);
        }
    }
}
