using System;
using System.Linq;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.CreateTypes.Collections
{
    public class ArrayCommand : DemoCommand
    {
        public ArrayCommand()
        {
            //AddResource("Enums", @"C# In A Nutshell, Location 13617");
        }

        public override string Description
        {
            get { return "Arrays"; }
        }

        public override void ExecuteDemo()
        {
            JaggedArrayDemo();
        }

        private void JaggedArrayDemo()
        {
            var sut = new string[][] {new[] {"A", "B"}, new[] {"C", "D", "E"}};
            Console.WriteLine("Rank : {0}", sut.Rank);
            Console.WriteLine("Count: {0}", sut.Count());
        }
    }
}
