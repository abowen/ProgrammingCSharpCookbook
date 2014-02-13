using System;
using System.Linq;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ImplementDataAccess.Linq.General
{
    public class JoinPerformanceCommand : DemoCommand
    {
        public JoinPerformanceCommand()
        {
            AddResource("Join over SelectMany", "C# In A NutShell, Location 17134");
        }

        public override string Description
        {
            get { return "Join over SelectMany Performance"; }
        }

        public override void ExecuteDemo()
        {            
            
        }        
    }
}

