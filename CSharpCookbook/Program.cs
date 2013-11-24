using System;
using CSharpCookbook.ManageProgramFlow.Asynchronous;

namespace CSharpCookbook
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("START");
            var commandTree = new CommandTree();
            commandTree.AddCommand(new AsynchronousCommand());          
            commandTree.ExecuteCommands();
            Console.WriteLine("FINISH");
            Console.ReadLine();
        }
    }
}
