using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ConsumeTypes.Casting
{
    public class ConvertCommand : DemoCommand
    {
        public ConvertCommand()
        {
            AddResource("Convert Class", "http://msdn.microsoft.com/en-us/library/system.convert(v=vs.110).aspx");
        }

        public override string Description
        {
            get { return "Convert"; }
        }

        public override void ExecuteDemo()
        {
            var stringValue = "123";
            var intValue = Convert.ToInt32(stringValue);            
        }
    }    
}
