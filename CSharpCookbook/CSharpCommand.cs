using CSharpCookbook.BaseCommands;
using CSharpCookbook.ManageProgramFlow;

namespace CSharpCookbook
{
    public class CSharpCommand : DisplayCommand
    {
        public override string Description { get { return @"Programming in C#"; } }

        public CSharpCommand()
        {
            AddCommand(new ManageProgramFlowCommand());            
        }
    }
}
