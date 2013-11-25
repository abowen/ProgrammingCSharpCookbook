using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ProgramFlow.Iteration
{
    public class IteratorCommand : DemoCommand
    {
        public IteratorCommand()
        {
            AddResource("Using Iterators", "http://msdn.microsoft.com/en-us/library/vstudio/65zzykke(v=vs.100).aspx");
        }

        public override string Description
        {
            get { return "Iterator"; }
        }

        public override void ExecuteDemo()
        {
            var someEnumerable = new SomeEnumerable();
            var output = string.Join(",", someEnumerable);
            Console.WriteLine(output);
        }

        public class SomeEnumerable : IEnumerable<int>
        {
            IEnumerator<int> IEnumerable<int>.GetEnumerator()
            {
                return Enumerable.Repeat(5, 20).GetEnumerator();
            }

            public IEnumerator GetEnumerator()
            {
                return Enumerable.Repeat(5, 20).GetEnumerator();
            }
        }
    }
}

