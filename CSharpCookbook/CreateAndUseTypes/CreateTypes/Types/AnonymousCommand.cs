using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.CreateTypes.Types
{
    public class AnonymousCommand : DemoCommand
    {
        public AnonymousCommand()
        {
            AddResource("Anonymous Types", "C# In A NutShell, Location 7464");
        }

        public override string Description
        {
            get { return "Anonymous"; }
        }

        public override void ExecuteDemo()
        {
            var anon = new { Value = 123 };                        
            Console.WriteLine("Anonymous HashCode {0}", anon.GetHashCode());
            Console.WriteLine("Anonymous Value {0}", anon.Value);

            var anonArray = new[]
            {
                new {Name = "Andrew", Age = 30},
                new {Name = "James", Age = 40},
            };

            Console.WriteLine("Anonymous Array");
            Array.ForEach(anonArray, obj => Console.WriteLine(obj.Name));
        }
    }
}
