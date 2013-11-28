using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.CreateTypes.Methods
{
    public class ExtensionCommand : DemoCommand
    {
        public ExtensionCommand()
        {
            AddResource("Extension Methods", "http://msdn.microsoft.com/en-us/library/vstudio/bb383977.aspx");
        }

        public override string Description
        {
            get { return "Extension Methods"; }
        }

        public override void ExecuteDemo()
        {
            Console.WriteLine("Extension: {0}", "StringValue".MyCustomExtension());
        }
    }

    public static class MyExtensionCommand
    {
        public static string MyCustomExtension(this string value)
        {
            return value + " MyExtension";
        }
    }
    
}
