using CSharpCookbook.BaseCommands;
using CSharpCookbook.CreateAndUseTypes.ReflectionAndMetadata.Attributes;
using CSharpCookbook.CreateAndUseTypes.ReflectionAndMetadata.Instantiate;
using CSharpCookbook.CreateAndUseTypes.ReflectionAndMetadata.Types;

namespace CSharpCookbook.CreateAndUseTypes.ReflectionAndMetadata
{
    public class ReflectionCommand : DisplayCommand
    {
        public override string Description
        {
            get { return "Reflection and Metadata"; }
        }

        public ReflectionCommand()
        {
            AddCommand(new CreateCommand());
            AddCommand(new ReadCommand());
            AddCommand(new TypeCommand());
            AddCommand(new ArrayCommand());
            AddCommand(new NestedCommand());
            AddCommand(new InterfaceCommand());
            AddCommand(new CreateInstanceCommand());
            AddCommand(new ConstructorInfoCommand());
            AddCommand(new NonPublicCommand());
            AddCommand(new CreateDelegateCommand());
        }
    }
}