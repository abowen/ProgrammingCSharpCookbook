using CSharpCookbook.BaseCommands;
using CSharpCookbook.CreateAndUseTypes.Reflection.Attributes;

namespace CSharpCookbook.CreateAndUseTypes.Reflection
{
    public class ReflectionCommand : DisplayCommand
    {
        public override string Description
        {
            get { return "Reflection"; }
        }

        public ReflectionCommand()
        {
            AddCommand(new ReadCommand());
        }
    }
}