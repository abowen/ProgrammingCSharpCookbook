using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ProgramFlow.ConditionalLogic
{
    public class SwitchCommand : DemoCommand
    {
        public override string Description
        {
            get { return "Switch Statement"; }
        }

        public override void ExecuteDemo()
        {
            Console.WriteLine("Enter a value between 1-3");
            var key = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int value;
            int.TryParse(key.ToString(), out value);
            switch (value)
            {
                case 1 : Console.WriteLine("One Selected");
                    break;
                case 2: Console.WriteLine("Two Selected");
                    break;
                case 3: Console.WriteLine("Three Selected");
                    break;                
                default: Console.WriteLine("Enter between 1-3");
                    break;
            }            
        }
    }
}
