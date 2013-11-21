using System;
using CSharpCookbook.ManageProgramFlow;

namespace CSharpCookbook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Manage program flow");
            var readLine = Console.ReadLine();
            var value = int.Parse(readLine);
            switch (value)
            {
                case 1 :
                    Console.WriteLine("1. ParallelFor");
                    readLine = Console.ReadLine();
                    var command = new ParallelForCommand();
                    command.Execute();
                    break;
            }
            

            Console.WriteLine("FINISH");
            Console.ReadLine();
        }
    }
}
