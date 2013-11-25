using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ProgramFlow.Operators
{
    public class GlobalCommand : DemoCommand
    {
        public GlobalCommand()
        {
            AddResource("Global Namespace Alias", "http://msdn.microsoft.com/en-us/library/c3ay4x3d.aspx");
        }

        public override string Description
        {
            get { return ":: Global Namespace"; }
        }

        public override void ExecuteDemo()
        {
            global::System.Console.WriteLine("View the Source Code");
        }
    }
}