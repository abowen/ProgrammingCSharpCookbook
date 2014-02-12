using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ProgramFlow.ConditionalLogic
{
    public class GotoTryFinallyCommand : DemoCommand
    {
        public GotoTryFinallyCommand()
        {
            AddResource("The goto statement", @"http://msdn.microsoft.com/en-us/library/aa664758(v=vs.71).aspx");
        }

        public override string Description
        {
            get { return "Goto Try Finally"; }
        }

        public override void ExecuteDemo()
        {
            try
            {
                Console.WriteLine("Try");
                goto exit;
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            exit: ;    
            Console.WriteLine("Return");            
        }        
    }
}
