using System;
using System.Linq;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ReflectionAndMetadata.Attributes
{
    public class ReadCommand : DemoCommand
    {
        public ReadCommand()
        {
            AddResource("Accessing Attributes using Reflection", "http://msdn.microsoft.com/en-us/library/z919e8tw%28v=vs.120%29.aspx");
        }

        public override string Description
        {
            get { return "Read Attributes"; }
        }

        public override void ExecuteDemo()
        {                        
            var attributes = Attribute.GetCustomAttributes(typeof(string), true); 
            Console.WriteLine("STRING ATTRIBUTES");
            attributes.ToList().ForEach(Console.WriteLine);            
        }
    }
}
