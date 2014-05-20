using System;
using System.Linq;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ImplementDataAccess.LinqOperators.Scalar
{
    public class AggregateCommand : DemoCommand
    {
        public AggregateCommand()
        {
            AddResource("Aggregate", "C# In A NutShell, Location 18209");
        }

        public override string Description
        {
            get { return "Aggregate"; }
        }

        public override void ExecuteDemo()
        {
            var numbers = new [] {1, 2, 3, 4};
            var y = numbers.Aggregate((prod, n) => prod*n);
            numbers.ToList().ForEach(i => Console.Write("{0},", i));
            Console.WriteLine(y);
        }        
    }
}

