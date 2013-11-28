using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.CreateTypes.Types
{
    public class GenericClassCommand : DemoCommand
    {
        public GenericClassCommand()
        {
            AddResource("Generics", "http://msdn.microsoft.com/en-us/library/vstudio/512aeb7t.aspx");            
        }

        public override string Description
        {
            get { return "Generic Class"; }
        }

        public override void ExecuteDemo()
        {
            var classA = new MyCustomGenericClass<int> { Value = 123 };
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

    public class MyCustomGenericClass<T>
    {
        public T Value;        
    }
}
