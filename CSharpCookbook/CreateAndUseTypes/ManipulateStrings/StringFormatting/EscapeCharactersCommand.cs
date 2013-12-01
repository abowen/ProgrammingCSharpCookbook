using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ManipulateStrings.StringFormatting
{
    public class EscapeCharactersCommand : DemoCommand
    {
        public EscapeCharactersCommand()
        {
            AddResource("Accessing Attributes using Reflection", "http://msdn.microsoft.com/en-us/library/z919e8tw%28v=vs.120%29.aspx");
        }

        public override string Description
        {
            get { return "Escape Characters"; }
        }

        public override void ExecuteDemo()
        {
            Console.WriteLine("Single Quote    : |\'|");
            Console.WriteLine("Double Quote    : |\"|");
            Console.WriteLine("BackSlash       : |\\|");
            Console.WriteLine("Null            : |\0|");
            Console.WriteLine("Backspace       : |\b|");
            Console.WriteLine("Form Feed       : |\f|");
            Console.WriteLine("New Line        : |\n|");
            Console.WriteLine("Carriage Return : |\r|");
            Console.WriteLine("Horizontal Tab  : |\t|");
            Console.WriteLine("Vertical Tab    : |\v|");
            Console.WriteLine();
            Console.WriteLine("Unicode Escaped : |\u00A9|");
            Console.WriteLine("File Escaped    : |{0}|", @"c:\temp.log");
            
        }
    }
}
