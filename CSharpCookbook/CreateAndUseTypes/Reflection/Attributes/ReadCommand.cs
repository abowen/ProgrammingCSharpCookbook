using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.Reflection.Attributes
{
    public class ReadCommand : DemoCommand
    {
        public ReadCommand()
        {
            AddResource("Accessing Attributes using Reflection", "http://msdn.microsoft.com/en-us/library/z919e8tw%28v=vs.120%29.aspx");
        }

        public override string Description
        {
            get { return "Read"; }
        }

        public override void ExecuteDemo()
        {
            var myInstance = new MyAttributeClass();
            var type = myInstance.GetType();
            var attributes = Attribute.GetCustomAttributes(type); 

            foreach (var attribute in attributes)
            {
                Console.WriteLine("TypeId : {0}", attribute.TypeId);
                var myAttribute = attribute as MyAttribute;
                if (myAttribute != null)
                {
                    Console.WriteLine("MyAttribute : {0}", myAttribute.GetDisplay());
                }
            }
        }
    }

    [MyAttribute("AttributeValue", Number = 1)]
    public class MyAttributeClass
    {
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class MyAttribute : Attribute
    {
        readonly string _myValue;

        public MyAttribute(string myValue)
        {
            _myValue = myValue;
        }

        public string GetDisplay()
        {
            return _myValue + " " + Number;
        }

        public int Number;
    }
}
