using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ConsumeTypes.Casting
{
    public class DynamicCommand : DemoCommand
    {
        public DynamicCommand()
        {
            AddResource("Using Type dynamic", "http://msdn.microsoft.com/en-us/library/dd264736.aspx");
            AddResource("Dynamic Binding", "C# In A NutShell, Location 7501");
        }

        public override string Description
        {
            get { return "Dynamic"; }
        }

        public override void ExecuteDemo()
        {
            dynamic instance = new MyDynamicClass();
            instance.MyDynamicMethod();

            DynamicMethod(instance);
            Console.WriteLine("Value Returned: {0}", DynamicReturnMethod(1,2));
        }

        public void DynamicMethod(dynamic dynamicObject)
        {
            dynamicObject.MyDynamicMethod();
        }

        public dynamic DynamicReturnMethod(dynamic x, dynamic y)
        {
            return x + y;
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

