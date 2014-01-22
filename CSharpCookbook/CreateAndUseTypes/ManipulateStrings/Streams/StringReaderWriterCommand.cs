using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Xml;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ManipulateStrings.Streams
{
    public class StringReaderWriterCommand : DemoCommand
    {
        public StringReaderWriterCommand()
        {
            AddResource("Streams and I/O", "C# In A Nutshell, Chapter 15");            
        }

        public override string Description
        {
            get { return "String Reader & Writer"; }
        }

        public override void ExecuteDemo()
        {
            StringWriterReaderDemo(@"StringWriterReaderDemo.xml");            
        }

        private static void StringWriterReaderDemo(string fileName)
        {            
            using (var writer = new StringWriter())
            {
                writer.WriteLine(@"<html>");
                writer.WriteLine(@"</html>");
                File.WriteAllText(fileName, writer.ToString());
            }
            using (TextReader reader = new StreamReader(fileName))
            {
                var xmlReader = XmlReader.Create(reader);
                xmlReader.Read();
                Console.WriteLine("{0} {1}", xmlReader.NodeType, xmlReader.Name);
            }
        }
    }
}
