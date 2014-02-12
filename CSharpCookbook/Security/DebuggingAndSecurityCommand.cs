using CSharpCookbook.BaseCommands;
using CSharpCookbook.Security.Security;
using CSharpCookbook.Security.Validation;

namespace CSharpCookbook.Security
{
    public class DebuggingAndSecurityCommand : DisplayCommand
    {
        public override string Description { get { return "Debug Applications and Implement Security"; } }

        public DebuggingAndSecurityCommand()
        {
            AddCommand(new ValidationCommand());
            AddCommand(new SecurityCommand());
        }
    }
}
