using System;
using CSharpCookbook.BaseCommands;
using CSharpCookbook.ImplementDataAccess.Mapping.SqlFu;

namespace CSharpCookbook.CreateAndUseTypes.CreateTypes.Constructors
{
    public class ConstructorOrderCommand : DemoCommand
    {
        static ConstructorOrderCommand()
        {
            //AddResource("Static Constructors", "http://msdn.microsoft.com/en-us/library/k9x6w0hc.aspx");            
        }

        public override string Description
        {
            get { return "Order of Constructors"; }
        }        

        public override void ExecuteDemo()
        {
            Console.WriteLine("Create Instance -> Call Static Method");
            new MyCustomConstructorOrderClass();            
            MyCustomConstructorOrderClass.MyCustomOrderMethod();                        
        }
    }
    
    public class MyCustomConstructorOrderClass
    {        
        static MyCustomConstructorOrderClass()
        {
            Console.WriteLine("Static Constructor Called");
        }

        public MyCustomConstructorOrderClass()
        {
            Console.WriteLine("Instance Constructor Called");
        }

        public static void MyCustomOrderMethod()
        {
            Console.WriteLine("Static Method Called");
        }
    }
}
