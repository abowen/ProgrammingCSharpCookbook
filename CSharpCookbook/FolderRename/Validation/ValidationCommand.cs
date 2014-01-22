using CSharpCookbook.BaseCommands;
using CSharpCookbook.DebuggingAndSecurity.Validation.JSON;

namespace CSharpCookbook.DebuggingAndSecurity.Validation
{
    public class ValidationCommand : DisplayCommand
    {
        public override string Description
        {
            get { return "Validate application input"; }
        }

        public ValidationCommand()
        {
            AddCommand(new JsonCommand());
        }
    }
}