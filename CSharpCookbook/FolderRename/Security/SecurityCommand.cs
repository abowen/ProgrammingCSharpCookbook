using CSharpCookbook.BaseCommands;
using CSharpCookbook.DebuggingAndSecurity.Security.Cryptography;

namespace CSharpCookbook.DebuggingAndSecurity.Security
{
    public class SecurityCommand : DisplayCommand
    {
        public override string Description
        {
            get { return "Security"; }
        }

        public SecurityCommand()
        {
            AddCommand(new WindowsDataProtectionCommand());
            AddCommand(new HashingCommand());
        }
    }
}