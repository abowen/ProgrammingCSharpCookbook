using CSharpCookbook.BaseCommands;
using CSharpCookbook.DebuggingAndSecurity.Security;
using CSharpCookbook.DebuggingAndSecurity.Validation;

namespace CSharpCookbook.DebuggingAndSecurity
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
