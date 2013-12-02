using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ReflectionAndMetadata.Attributes
{
    public class CreateCommand : DemoCommand
    {
        public CreateCommand()
        {
            AddResource("Creating Custom Attributes", "http://msdn.microsoft.com/en-us/library/sw480ze8.aspx");
        }

        public override string Description
        {
            get { return "Create Attributes"; }
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

    [My("AttributeValue", Number = 1)]
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
