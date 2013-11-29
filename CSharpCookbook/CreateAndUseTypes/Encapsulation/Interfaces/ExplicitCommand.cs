using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.Encapsulation.Interfaces
{
    public class ExplicitCommand : DemoCommand
    {
        public ExplicitCommand()
        {
            AddResource("Explicit Interface Implementation", "http://msdn.microsoft.com/en-us/library/ms173157.aspx");            
        }

        public override string Description
        {
            get { return "Explicit Interface"; }
        }

        public override void ExecuteDemo()
        {
            var interfaceClass = new ExplicitInterfaceClass();
            ((IExplicitInterfaceA)interfaceClass).Sample();
            ((IExplicitInterfaceB)interfaceClass).Sample();
            //interfaceClass.Sample(); Can't call
        }
    }

    public interface IExplicitInterfaceA
    {
        void Sample();
    }

    public interface IExplicitInterfaceB
    {
        void Sample();
    }

    public class ExplicitInterfaceClass : IExplicitInterfaceA, IExplicitInterfaceB
    {
        void IExplicitInterfaceA.Sample()
        {
            Console.WriteLine("MyExplicitInterfaceA.Sample");
        }

        void IExplicitInterfaceB.Sample()
        {
            Console.WriteLine("MyExplicitInterfaceB.Sample");
        }
    }
}
