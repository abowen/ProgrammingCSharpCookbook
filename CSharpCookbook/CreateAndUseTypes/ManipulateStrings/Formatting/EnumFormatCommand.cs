using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ManipulateStrings.Formatting
{
    public class EnumFormatCommand : DemoCommand
    {
        public EnumFormatCommand()
        {
            AddResource("Enum Format Strings", "C# In A NutShell, Location 10803");
        }

        public override string Description
        {
            get { return "Enum Formatting"; }
        }

        public override void ExecuteDemo()
        {
            var testEnum = ConsoleColor.Red;
            Console.WriteLine(testEnum.ToString());
            Console.WriteLine(testEnum.ToString("G"));
            Console.WriteLine(testEnum.ToString("F"));
            Console.WriteLine(testEnum.ToString("D"));
            Console.WriteLine(testEnum.ToString("X"));
        }
    }
}
