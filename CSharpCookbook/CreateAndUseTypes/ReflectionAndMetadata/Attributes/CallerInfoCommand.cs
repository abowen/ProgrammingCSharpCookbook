using System;
using System.Runtime.CompilerServices;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ReflectionAndMetadata.Attributes
{
    public class CallerInfoCommand : DemoCommand
    {
        public CallerInfoCommand()
        {
            AddResource("Caller Info Attributes", "C# In A NutShell,. Location 7837");
        }

        public override string Description
        {
            get { return "CallerInfo"; }
        }

        public override void ExecuteDemo()
        {
            GetCallerInfo();
        }

        static void GetCallerInfo([CallerMemberName] string memberName = null,
            [CallerFilePath] string filePath = null, 
            [CallerLineNumber] int lineNumber = 0)
        {
            Console.WriteLine("Member Name: {0}", memberName);
            Console.WriteLine("File Path: {0}", filePath);
            Console.WriteLine("Line Number: {0}", lineNumber);
        }
    }    
}

