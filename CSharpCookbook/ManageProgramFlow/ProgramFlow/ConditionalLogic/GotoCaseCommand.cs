using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ProgramFlow.ConditionalLogic
{
    public class GotoCaseCommand : DemoCommand
    {
        public GotoCaseCommand()
        {
            AddResource("Switch C# Reference", "http://msdn.microsoft.com/en-US/library/vstudio/06tc147t.aspx");
        }

        public override string Description
        {
            get { return "Goto Case"; }
        }

        public override void ExecuteDemo()
        {
            Console.WriteLine("Enter a value between 1-9");
            var key = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int value;
            int.TryParse(key.ToString(), out value);
            switch (value)
            {
                case 1 : Console.WriteLine("One Always Selected");
                    break;
                case 2: Console.WriteLine("Too Bad");
                    goto case 1;                
                default: Console.WriteLine("Too Bad");
                    goto case 1;
            }            
        }
    }
}
