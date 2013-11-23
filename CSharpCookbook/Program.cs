using System;
using CSharpCookbook.ManageProgramFlow;

namespace CSharpCookbook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("START");
            var commandTree = new CommandTree();
            commandTree.AddCommand(new ListCommand());          
            commandTree.ExecuteCommands();
            Console.WriteLine("FINISH");
            Console.ReadLine();
        }
    }
}
