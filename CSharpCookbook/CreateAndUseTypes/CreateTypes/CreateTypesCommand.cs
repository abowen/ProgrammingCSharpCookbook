using CSharpCookbook.BaseCommands;
using CSharpCookbook.CreateAndUseTypes.CreateTypes.Collections;
using CSharpCookbook.CreateAndUseTypes.CreateTypes.Constructors;
using CSharpCookbook.CreateAndUseTypes.CreateTypes.Methods;
using CSharpCookbook.CreateAndUseTypes.CreateTypes.Properties;
using CSharpCookbook.CreateAndUseTypes.CreateTypes.Types;

namespace CSharpCookbook.CreateAndUseTypes.CreateTypes
{
    public class CreateTypesCommand : DisplayCommand
    {
        public override string Description
        {
            get { return "Create Types"; }
        }

        public CreateTypesCommand()
        {
            AddCommand(new AnonymousCommand());
            AddCommand(new ClassCommand());
            AddCommand(new StructCommand());
            AddCommand(new GenericClassCommand());
            AddCommand(new ConstructorOrderCommand());
            AddCommand(new ConstructorBaseCommand());
            AddCommand(new ConstructorStaticCommand());
            AddCommand(new ConstructorPrivateCommand());
            AddCommand(new OptionalCommand());
            AddCommand(new VirtualCommand());
            AddCommand(new ExtensionCommand());
            AddCommand(new NewCommand());
            AddCommand(new OverloadCommand());
            AddCommand(new IndexerCommand());
            AddCommand(new EnumCommand());
            AddCommand(new ArrayCommand());
            AddCommand(new CustomCollectionCommand());
            AddCommand(new CollectionPerformanceCommand());
        }
    }
}