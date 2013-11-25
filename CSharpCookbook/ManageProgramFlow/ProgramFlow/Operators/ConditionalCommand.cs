using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ManageProgramFlow.ProgramFlow.Operators
{
    public class ConditionalCommand : DemoCommand
    {
        public ConditionalCommand()
        {
            AddResource("?: Operator", "http://msdn.microsoft.com/en-us/library/ty67wk28.aspx");
        }

        public override string Description
        {
            get { return "?: Operator"; }
        }

        public override void ExecuteDemo()
        {
            Console.WriteLine("Enter a positive or negative number");
            int input = Convert.ToInt32(Console.ReadLine());
            var output = input >= 0 ? "Positive" : "Negative";
            Console.WriteLine(output);
        }
    }
}
