using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.CreateTypes.Types
{
    public class EnumCommand : DemoCommand
    {
        public EnumCommand()
        {
            AddResource("Enums", @"C# In A Nutshell, Location 11370");            
        }

        public override string Description
        {
            get { return "Enum"; }
        }

        public override void ExecuteDemo()
        {
            ExplicitEnumParameter(Sides.Top);
            BaseEnumParameter(Sides.Bottom);
            EnumEnumerate();
            EnumValues(Sides.Right);
            EnumValues(Sides.Left | Sides.Top);
        }

        private static void EnumValues(Sides inputValue)
        {            
            Console.WriteLine("Value: {0} - {1}", (int)inputValue, inputValue);            
        }

        private void ExplicitEnumParameter(Sides inputValue)
        {
            Console.WriteLine(inputValue.GetType().Name + "." + inputValue);
        }

        private void BaseEnumParameter(Enum inputValue)
        {
            Console.WriteLine(inputValue.GetType().Name + "." + inputValue);
        }

        private void EnumEnumerate()
        {
            foreach (var side in Enum.GetValues(typeof(Sides)))
            {
                Console.WriteLine(side);
            }
        }
    }

    [Flags]
    public enum Sides
    {
        Top = 1,
        Left = 2,
        Right = 4,
        Bottom = 8
    }
}
