using System;
using System.Collections.ObjectModel;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.CreateTypes.Collections
{
    public class CustomCollectionCommand : DemoCommand
    {
        public CustomCollectionCommand()
        {
            AddResource("Enums", @"C# In A Nutshell, Location 13617");
        }

        public override string Description
        {
            get { return "Custom Collections"; }
        }

        public override void ExecuteDemo()
        {
            var myCollection = new MyCollection<string>();
            myCollection.Add("Hello");
        }

    }

    public class MyCollection<T> : Collection<T>
    {
        protected override void InsertItem(int index, T item)
        {
            Console.WriteLine("Item Added: {0}", item);
            base.InsertItem(index, item);
        }
    }
}
