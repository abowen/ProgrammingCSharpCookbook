using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ReflectionAndMetadata.Instantiate
{
    public class CreateDelegateCommand : DemoCommand
    {
        public CreateDelegateCommand()
        {
            AddResource("Reflection and Metadata", "C# in a Nutshell, Chapter 19. Reflection and Metadata");
        }

        public override string Description
        {
            get { return "Create Delegate"; }
        }

        public override void ExecuteDemo()
        {
            var staticDelegate = Delegate.CreateDelegate(typeof(MyDelegate), typeof(MyDelegateClass), "StaticMethod");
            var instanceDelegate = Delegate.CreateDelegate(typeof(MyDelegate), new MyDelegateClass(), "InstanceMethod");
            Console.WriteLine(staticDelegate.DynamicInvoke(1));
            Console.WriteLine(instanceDelegate.DynamicInvoke(2));
        }

        private delegate string MyDelegate(int value);
    }

    public class MyDelegateClass
    {        
        static string StaticMethod(int value)
        {
            return string.Format("StaticValue {0}", value);
        }

        string InstanceMethod(int value)
        {
            return string.Format("InstanceValue {0}", value);
        }
    }
}
