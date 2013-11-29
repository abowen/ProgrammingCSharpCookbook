using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.Encapsulation.Properties
{
    public class PropertiesCommand : DemoCommand
    {
        public PropertiesCommand()
        {
            AddResource("Properties", "http://msdn.microsoft.com/en-us/library/x9fsa0sw.aspx");            
        }

        public override string Description
        {
            get { return "Properties"; }
        }

        public override void ExecuteDemo()
        {
            var myPropertiesClass = new MyPropertiesClass();
            Console.WriteLine(myPropertiesClass.PublicGet);
            Console.WriteLine(myPropertiesClass.PublicGetPrivateSet);
            myPropertiesClass.PublicGetSet = "PublicGetSet";
            Console.WriteLine(myPropertiesClass.PublicGetSet);
            Console.WriteLine(myPropertiesClass.PublicReadonly);
        }
    }

    public class MyPropertiesClass
    {
        public MyPropertiesClass()
        {
            PublicGetPrivateSet = "PublicGetPrivateSet";
        }

        public readonly string PublicReadonly = "PublicReadonly";
        public string PublicGetSet { get; set; }
        public string PublicGetPrivateSet { get; private set; }

        public string PublicGet
        {
            get { return "PublicGet"; }
        }
    }
}
