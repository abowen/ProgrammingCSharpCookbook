using System;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ConsumeTypes.Casting
{
    public class CastCommand : DemoCommand
    {
        public CastCommand()
        {
            AddResource("Casting and Type Conversions", "http://msdn.microsoft.com/en-us/library/ms173105.aspx");
        }

        public override string Description
        {
            get { return "Cast"; }
        }

        public override void ExecuteDemo()
        {
            var decimalValue = 123.456m;
            Console.WriteLine("Initial Type: {0}", decimalValue.GetType());
            var intValue = (int)decimalValue;
            Console.WriteLine("Cast Type: {0}", intValue.GetType());
        }
    }    
}

