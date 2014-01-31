using System;
using System.Linq;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ImplementDataAccess.Linq.General
{
    public class IntoCommand : DemoCommand
    {
        public IntoCommand()
        {
            AddResource("The into Keyword", "C# In A NutShell, Location 14855");
        }

        public override string Description
        {
            get { return "Into"; }
        }

        public override void ExecuteDemo()
        {            
            QueryContinuationDemo();
            //GroupJoinDemo();
        }

        private readonly string[] _names = { "Andrew", "James", "Bowen", "Thomas", "Michael", "Beth" };

        private void QueryContinuationDemo()
        {
            Console.WriteLine("Query Continuation");
            Console.WriteLine();
            Console.WriteLine("Fluent Syntax");

            var queryFluent = _names
                .Select(n => n.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", ""))
                .Where(n => n.Length > 2)
                .OrderBy(n => n);

            queryFluent.ToList().ForEach(Console.WriteLine);

            Console.WriteLine();
            Console.WriteLine("Without Into");

            var queryWithoutInto =
                from n in _names
                select n.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "");

            queryWithoutInto = 
                    from noVowel in queryWithoutInto
                    where noVowel.Length > 2
                    orderby noVowel
                    select noVowel;

            queryWithoutInto.ToList().ForEach(Console.WriteLine);

            Console.WriteLine();
            Console.WriteLine("With Into");

            var queryWithInto =
                from n in _names
                select n.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "")
                into noVowel
                    where noVowel.Length > 2
                    orderby noVowel
                    select noVowel;

            queryWithInto.ToList().ForEach(Console.WriteLine);
        }
    }
}

