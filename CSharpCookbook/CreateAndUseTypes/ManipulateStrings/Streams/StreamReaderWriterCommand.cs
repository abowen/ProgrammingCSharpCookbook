using System.Diagnostics.Contracts;
using System.IO;
using System.Text;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ManipulateStrings.Streams
{
    public class StreamReaderWriterCommand : DemoCommand
    {
        public StreamReaderWriterCommand()
        {
            AddResource("Streams and I/O", "C# In A Nutshell, Chapter 15");            
        }

        public override string Description
        {
            get { return "Stream Reader & Writer"; }
        }

        public override void ExecuteDemo()
        {
            var namePrefix = "StreamReaderWriterCommand";
            StreamWriterReaderDemo(namePrefix + "01.txt");
            FileCreateTextDemo(namePrefix + "02.txt");
            EncodingDemo(namePrefix + "03.txt");
        }

        private static void StreamWriterReaderDemo(string fileName)
        {
            var content = "StreamWriterReaderDemo";
            using (var writer = new StreamWriter(fileName))
            {
                writer.WriteLine(content);
            }
            using (var reader = new StreamReader(fileName))
            {
                var readLine = reader.ReadLine();
                Contract.Assert(readLine == content);
            }
        }

        private static void FileCreateTextDemo(string fileName)
        {
            var content = "FileCreateTextDemo";
            using (var writer = File.CreateText(fileName))
            {
                writer.WriteLine(content);
            }
            using (var reader = File.OpenText(fileName))
            {
                var readLine = reader.ReadLine();
                Contract.Assert(readLine == content);
            }
        }

        private static void EncodingDemo(string fileName)
        {
            var content = "StreamWriterReaderDemo";

            var encodingWithoutIdentifier = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);

            using (var writer = new StreamWriter(fileName, false, encodingWithoutIdentifier))
            {
                writer.WriteLine(content);
            }
            using (var reader = new StreamReader(fileName))
            {
                var readLine = reader.ReadLine();
                Contract.Assert(readLine == content);
            }
        }
    }
}
