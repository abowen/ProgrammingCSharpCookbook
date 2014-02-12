using CSharpCookbook.BaseCommands;
using CSharpCookbook.Security.Validation.JSON;

namespace CSharpCookbook.Security.Validation
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