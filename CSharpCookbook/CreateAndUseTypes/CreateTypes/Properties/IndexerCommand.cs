using System;
using System.Collections.Generic;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.CreateTypes.Properties
{
    public class IndexerCommand : DemoCommand
    {
        public IndexerCommand()
        {
            AddResource("Using Indexers", "http://msdn.microsoft.com/en-us/library/vstudio/2549tw02.aspx");
        }

        public override string Description
        {
            get { return "Indexer"; }
        }

        public override void ExecuteDemo()
        {
            var values = new SomeIndexer();
            values.AddValue(5);
            values.AddValue(12);            
            var output = string.Join(",", values[0], values[1]);
            Console.WriteLine(output);
        }

        public class SomeIndexer
        {            
            public void AddValue(int value)
            {
                _values.Add(value);
            }

            public int this[int index]
            {
                get
                {
                    return _values[index];
                }
                set
                {
                    _values[index] = value;
                }
            }

            private readonly List<int> _values = new List<int>();

        }
    }
}

