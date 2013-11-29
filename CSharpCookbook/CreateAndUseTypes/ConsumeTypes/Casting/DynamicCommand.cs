using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ConsumeTypes.Casting
{
    public class DynamicCommand : DemoCommand
    {
        public DynamicCommand()
        {
            AddResource("Using Type dynamic", "http://msdn.microsoft.com/en-us/library/dd264736.aspx");
        }

        public override string Description
        {
            get { return "Dynamic"; }
        }

        public override void ExecuteDemo()
        {
            dynamic myDynamicClass = new MyDynamicClass();
            myDynamicClass.MyDynamicMethod();
        }
    }    

    public class MyDynamicClass
    {
        public void MyDynamicMethod()
        {
            Console.WriteLine("Dynamic Method");
        }
    }
}

