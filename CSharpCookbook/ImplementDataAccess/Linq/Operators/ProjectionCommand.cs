using System;
using System.Linq;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ImplementDataAccess.Linq.Operators
{
    public class ProjectionCommand : DemoCommand
    {
        public ProjectionCommand()
        {
            AddResource("LINQ", "C# In A NutShell, Location 14015");
        }

        public override string Description
        {
            get { return "Projection"; }
        }        

        public override void ExecuteDemo()
        {
            ProjectClassDemo();
            ProjectAnonymousDemo();
        }

        private void ProjectAnonymousDemo()
        {
            Console.WriteLine("Projection - Anonymous");
            var projectionAnon = _names
                .Select(n =>
                    new
                    {
                        Original = n,
                        Vowelless = n.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "")
                    });
            projectionAnon.ToList().ForEach(Console.WriteLine);
        }

        private void ProjectClassDemo()
        {
            Console.WriteLine("Projection - Class");
            var projection = _names
                .Select(n =>
                    new TempProjection
                    {
                        Original = n,
                        Vowelless = n.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "")
                    });
            projection.ToList().ForEach(Console.WriteLine);
        }

        private readonly string[] _names = { "Andrew", "James", "Bowen", "Thomas", "Michael", "Beth" };
    }

    public class TempProjection
    {
        public string Original { get; set; }
        public string Vowelless { get; set; }

        public override string ToString()
        {
            return string.Format("Original: {0} - Vowelless {1}", Original, Vowelless);
        }
    }
}

