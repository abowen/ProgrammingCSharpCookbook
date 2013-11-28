using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.CreateTypes.Methods
{
    public class NewCommand : DemoCommand
    {
        public NewCommand()
        {
            AddResource("new Modifier", "http://msdn.microsoft.com/en-us/library/435f1dw2.ASPX");
        }

        public override string Description
        {
            get { return "New Methods"; }
        }

        public override void ExecuteDemo()
        {
            var instance = new MyNewInheritedMethodClass();
            instance.MyCustomMethod();

            var baseInstance = new MyNewMethodClass();
            baseInstance.MyCustomMethod();
        }        
    }

    public class MyNewMethodClass
    {
        public int MyValue = 5;

        public void MyCustomMethod()
        {
            Console.WriteLine("MyNewMethodClass {0}", MyValue);
        }
    }

    public class MyNewInheritedMethodClass : MyNewMethodClass
    {
        public new int MyValue = 10;

        public new void MyCustomMethod()
        {
            Console.WriteLine("MyNewInheritedMethodClass {0}", MyValue);            
        }
    }
}
