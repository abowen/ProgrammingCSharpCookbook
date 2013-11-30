using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ClassHierarchy.Interfaces
{
    public class EnumerableCommand : DemoCommand
    {
        public EnumerableCommand()
        {
            AddResource("Using Iterators", "http://msdn.microsoft.com/en-us/library/vstudio/65zzykke(v=vs.100).aspx");
        }

        public override string Description
        {
            get { return "IEnumerable"; }
        }

        public override void ExecuteDemo()
        {
            var myEnumerableClass = new MyEnumerableClass();            
            var output = string.Join(",", myEnumerableClass);
            Console.WriteLine(output);            
        }

        public class MyEnumerableClass : IEnumerable<int>
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

