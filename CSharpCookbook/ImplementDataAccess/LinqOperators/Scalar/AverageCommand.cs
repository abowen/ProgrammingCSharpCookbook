using System;
using System.Linq;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.ImplementDataAccess.LinqOperators.Scalar
{
    public class AverageCommand : DemoCommand
    {
        public AverageCommand()
        {
            AddResource("Average", "C# In A NutShell, Location 18295");
        }

        public override string Description
        {
            get { return "Average"; }
        }

        public override void ExecuteDemo()
        {
            var numbers = new [] {1, 2, 8, 4};
            var mean = numbers.Average();
            Console.WriteLine("Mean : {0}", mean);
            var deviation = Math.Sqrt(numbers.Average(n =>
            {
                double dif = n - mean;
                return dif*dif;
            }));
            Console.WriteLine("Std Dev : {0}", deviation);
        }        
    }
}

