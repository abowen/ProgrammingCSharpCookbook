using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.CreateTypes.Types
{
    public class ClassCommand : DemoCommand
    {
        public ClassCommand()
        {
            AddResource("Classes (C# Reference)", "http://msdn.microsoft.com/en-us/library/x9afc042.aspx");
            AddResource("Classes and Structs", "http://msdn.microsoft.com/en-us/library/ms173109.aspx");
        }

        public override string Description
        {
            get { return "Class"; }
        }

        public override void ExecuteDemo()
        {
            var classA = new MyCustomClass { Value = 123 };
            var classB = classA;
            Console.WriteLine("classA HashCode {0}", classA.GetHashCode());
            Console.WriteLine("classB HashCode {0}", classB.GetHashCode());
            Console.WriteLine("classA Value {0}", classA.Value);
            Console.WriteLine("classB Value {0}", classB.Value);
            Console.WriteLine();
            Console.WriteLine("structB Value Change");
            classB.Value = 789;
            Console.WriteLine("classA HashCode {0}", classA.GetHashCode());
            Console.WriteLine("classB HashCode {0}", classB.GetHashCode());
            Console.WriteLine("classA Value {0}", classA.Value);
            Console.WriteLine("classB Value {0}", classB.Value);            
        }
    }

    public class MyCustomClass
    {
        public int Value;        
    }
}
