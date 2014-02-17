using System;
using System.IO;
using System.Linq;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ImplementDataAccess.LinqOperators.Grouping
{
    public class GroupByCommand : DemoCommand
    {
        public GroupByCommand()
        {
            AddResource("LINQ", "C# In A NutShell, Location 17586");
        }

        public override string Description
        {
            get { return "GroupBy"; }
        }

        public override void ExecuteDemo()
        {
            var fileDirectory = @"C:\Windows";
            Console.WriteLine("File Directory {0}", fileDirectory);
            var files = Directory.GetFiles(fileDirectory);
            var query = files.GroupBy(Path.GetExtension);

            foreach (var fileGroup in query)
            {
                Console.WriteLine("Extension: {0}", fileGroup.Key);
                Console.WriteLine("Files {0}", fileGroup.Count());
            }
        }        
    }
}

