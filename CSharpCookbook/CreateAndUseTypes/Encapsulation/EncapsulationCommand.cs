using CSharpCookbook.BaseCommands;
using CSharpCookbook.CreateAndUseTypes.Encapsulation.Properties;

namespace CSharpCookbook.CreateAndUseTypes.Encapsulation
{
    public class EncapsulationCommand : DisplayCommand
    {
        public override string Description
        {
            get { return "Encapsulation"; }
        }

        public EncapsulationCommand()
        {
            AddCommand(new PropertiesCommand());            
        }
    }
}