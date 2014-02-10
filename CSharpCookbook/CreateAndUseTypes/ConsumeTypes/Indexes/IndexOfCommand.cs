using System;
using System.Collections.Generic;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ConsumeTypes.Indexes
{
    public class IndexOfCommand : DemoCommand
    {
        public IndexOfCommand()
        {
            //AddResource("Index Of", "http://msdn.microsoft.com/en-us/library/vstudio/2549tw02.aspx");
        }

        public override string Description
        {
            get { return "Index Of"; }
        }

        public override void ExecuteDemo()
        {
            var name = "Andrew";
            foreach (char c in name)
            {
                Console.WriteLine("{0} {1}", name.IndexOf(c), c);
            }
        }
    }
}

