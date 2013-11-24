using CSharpCookbook.BaseCommands;

namespace CSharpCookbook
{
    class Program
    {
        static void Main()
        {
            DisplayCommand command = new CSharpCommand();            
            command.ExecuteCommand();            
        }
    }
}
