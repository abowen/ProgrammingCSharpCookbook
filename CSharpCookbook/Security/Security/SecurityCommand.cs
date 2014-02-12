using CSharpCookbook.BaseCommands;
using CSharpCookbook.Security.Security.Cryptography;

namespace CSharpCookbook.Security.Security
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