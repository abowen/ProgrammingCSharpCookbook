using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ClassHierarchy.Inherit
{
    public class ClassCommand : DemoCommand
    {
        public ClassCommand()
        {
            AddResource("Inheritance", "http://msdn.microsoft.com/en-us/library/ms173149.aspx");
        }

        public override string Description
        {
            get { return "Class Inheritance"; }
        }

        public override void ExecuteDemo()
        {
            var myClass = new MyInheritedClass();
            myClass.MyMethod();
            ((MyClass)myClass).MyMethod();
        }
    }

    public class MyInheritedClass : MyClass
    {
        public MyInheritedClass()
        {
            Console.WriteLine("MyInheritedClass");
        }

        public new void MyMethod()
        {
            Console.WriteLine("MyInheritedClass MyMethod");
        }
    }

    public class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("MyClass");
        }

        public void MyMethod()
        {
            Console.WriteLine("MyClass MyMethod");
        }
    }
}
