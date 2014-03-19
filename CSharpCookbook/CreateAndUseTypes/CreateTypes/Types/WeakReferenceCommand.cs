using System;
using System.Text;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.CreateTypes.Types
{
    public class WeakReferenceCommand : DemoCommand
    {
        public WeakReferenceCommand()
        {
            AddResource("Weak References", @"C# In A Nutshell, Location 21885");              
        }

        public override string Description
        {
            get { return "Weak Reference"; }
        }

        public override void ExecuteDemo()
        {
            var stringBuilder = new StringBuilder("WEAK REFERENCE");
            Console.WriteLine("StringBuilder: {0}", stringBuilder);
            var weak = new WeakReference(stringBuilder);
            Console.WriteLine("Weak.Target: {0}",weak.Target);
        }
    }
}
