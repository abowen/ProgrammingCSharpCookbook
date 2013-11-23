using System;
using CSharpCookbook.ManageProgramFlow;

namespace CSharpCookbook
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandTree = new CommandTree();
            commandTree.AddCommand(new ParallelForBreakCommand());
            commandTree.AddCommand(new ParallelForCancelCommand());
            commandTree.AddCommand(new ParallelForCommand());
            
            
            commandTree.ExecuteCommands();

            Console.WriteLine("FINISH");
            Console.ReadLine();
        }
    }
}
