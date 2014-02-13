using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.CreateTypes.Generics
{
    public class GenericMethodsCommand : DemoCommand
    {
        public GenericMethodsCommand()
        {
            AddResource("Generics", "http://msdn.microsoft.com/en-us/library/vstudio/512aeb7t.aspx");            
        }

        public override string Description
        {
            get { return "Generic Method"; }
        }

        public override void ExecuteDemo()
        {
            var myGenericMethodClass = new MyGenericMethodClass<int>();
            myGenericMethodClass.MyMethod<string>();
        }
    }

    public class MyGenericMethodClass<T>
    {
        public MyGenericMethodClass()
        {
            Console.WriteLine(typeof(T).ToString());
        }

        public void MyMethod<T2>()
        {            
            Console.WriteLine(typeof(T2).ToString());
        }
    }
}
