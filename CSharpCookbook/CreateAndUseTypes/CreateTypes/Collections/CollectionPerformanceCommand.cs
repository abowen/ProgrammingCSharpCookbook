using System.Collections.Generic;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.CreateTypes.Collections
{
    public class CollectionPerformanceCommand : DemoCommand
    {
        public CollectionPerformanceCommand()
        {
            AddResource("Enums", @"C# In A Nutshell, Location 13289");
        }

        public override string Description
        {
            get { return "Collection Performance"; }
        }

        public override void ExecuteDemo()
        {            
            PerformanceTest(ListPerformanceDemo);            
            PerformanceTest(HashSetPerformanceDemo);
        }        

        private void ListPerformanceDemo()
        {
            var count = 100000;
            var collection = new List<string>();
            while(count > 0)
            {
                collection.Add("string0");
                collection.Remove("string0");
                count--;
            }                    
        }

        private void HashSetPerformanceDemo()
        {
            var count = 1000;
            var collection = new HashSet<string>();
            while(count > 0)
            {
                collection.Add("string0");
                collection.Remove("string0");
                count--;
            }            
        }
    }
}
