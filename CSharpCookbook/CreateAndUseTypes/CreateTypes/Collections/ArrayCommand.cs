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
            AddResource("Multidimensional Arrays", @"http://msdn.microsoft.com/en-us/library/2yd9wwz4.aspx");
        }

        public override string Description
        {
            get { return "Arrays"; }
        }

        public override void ExecuteDemo()
        {
            JaggedArrayDemo();
            MultidimensionArrayDemo();
        }

        private void JaggedArrayDemo()
        {
            Console.WriteLine("Jagged");
            var sut = new string[][] {new[] {"A", "B"}, new[] {"C", "D", "E"}};
            Console.WriteLine("Rank : {0}", sut.Rank);
            Console.WriteLine("Count: {0}", sut.Count());
        }

        private void MultidimensionArrayDemo()
        {
            Console.WriteLine("Multidimension");
            var sut = new int[2,3] {{1, 2, 3}, {4, 5, 6}};
            Console.WriteLine("Rank : {0}", sut.Rank);
            Console.WriteLine("UpperBound 0: {0}", sut.GetUpperBound(0));
            //Console.WriteLine("UpperBound 0: {0}", sut.Cou);
        }
    }
}
