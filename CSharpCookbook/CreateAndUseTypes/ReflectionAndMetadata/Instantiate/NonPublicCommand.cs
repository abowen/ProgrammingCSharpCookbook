using System;
using System.Reflection;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ReflectionAndMetadata.Instantiate
{
    public class NonPublicCommand : DemoCommand
    {
        public NonPublicCommand()
        {
            AddResource("Reflection and Metadata", "C# in a Nutshell, Chapter 19. Reflection and Metadata");
        }

        public override string Description
        {
            get { return "Non Public Constructor"; }
        }

        public override void ExecuteDemo()
        {
            var privateConstructorInfos = typeof(MyHiddenClass).GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var constructorInfo in privateConstructorInfos)
            {
                constructorInfo.Invoke(null);
            }
        }
    }

    public class MyHiddenClass
    {
        private MyHiddenClass()
        {
            Console.WriteLine("MyHiddenClass Found");
        }        
    }
}
