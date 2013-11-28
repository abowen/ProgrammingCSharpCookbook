using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.CreateTypes.Methods
{
    public class OptionalCommand : DemoCommand
    {
        public OptionalCommand()
        {
            AddResource("Named and Optional Arguments", "http://msdn.microsoft.com/en-us/library/vstudio/dd264739.aspx");
        }

        public override string Description
        {
            get { return "Optional Methods"; }
        }

        public override void ExecuteDemo()
        {
            MyOptionalMethods("Override");
        }

        public void MyOptionalMethods(string stringValue = "Default", bool boolValue = false)
        {
            Console.WriteLine("String {0} and Bool {1}", stringValue, boolValue);
        }
    }

    
}
