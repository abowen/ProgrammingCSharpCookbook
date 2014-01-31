using System;
using System.Linq;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ImplementDataAccess.Linq.General
{
    public class LetCommand : DemoCommand
    {
        public LetCommand()
        {
            AddResource("The let Keyword", "C# In A NutShell, Location 14957");
        }

        public override string Description
        {
            get { return "Let"; }
        }

        public override void ExecuteDemo()
        {
            var query =
                from n in _names
                let vowelless = n.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "")
                where vowelless.Length > 2
                orderby vowelless
                select new {Original = n, Vowelless = vowelless};

            query.ToList().ForEach(Console.WriteLine);
        }

        private readonly string[] _names = { "Andrew", "James", "Bowen", "Thomas", "Michael", "Beth" };

    }
}

