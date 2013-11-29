using System;
using System.Collections.Generic;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ClassHierarchy.Interfaces
{
    public class ComparableCommand : DemoCommand
    {
        public ComparableCommand()
        {
            AddResource("IComparable", "http://msdn.microsoft.com/en-us/library/system.icomparable%28v=vs.110%29.aspx");
        }

        public override string Description
        {
            get { return "IComparable"; }
        }

        public override void ExecuteDemo()
        {
            var instanceA = new MyComparableClass() { Value = 5 };
            var instanceB = new MyComparableClass() { Value = 10 };
            var instanceC = new MyComparableClass() { Value = 6 };
            var myComparableClasses = new List<MyComparableClass>() { instanceA, instanceB, instanceC };            
            myComparableClasses.Sort();
            foreach (var myComparableClass in myComparableClasses)
            {
                Console.WriteLine(myComparableClass.Value);
            }
        }
    }

    public class MyComparableClass : IComparable
    {
        public int Value { get; set; }

        public int CompareTo(object obj)
        {
            var value = (MyComparableClass)obj;
            if (value.Value < Value)
            {
                return 1;
            }
            if (value.Value > Value)
            {
                return -1;
            }
            return 0;
        }        
    }
}
