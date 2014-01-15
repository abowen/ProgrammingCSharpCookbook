using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ManipulateStrings.StringEncoding
{
    public class EncodingCommand : DemoCommand
    {
        public EncodingCommand()
        {
            AddResource("Pluralsight, Mastering C# 4.0", "http://pluralsight.com/training/Courses/TableOfContents/skeet-csharp4");
        }

        // By default, strings use Unicode / UTF16
        // Everything saved to memory is in bytes
         //var ab = "AB"; // 55, 66 as 4 bytes / 16 bit, hence UTF16
        // BMP is basic multilingual plane, where most characters assigned for nearly all modern languages
        // Range of char is 0-65535
        // Problem is surrogates, where there are 2 chars combined together
        // Treat UTF8 / Unicode like JPG / PNG
        // Never use Encoding.Default as it's system based, not .NET specified

        public override string Description
        {
            get { return "Encoding"; }
        }

        public override void ExecuteDemo()
        {
            var bytes8 = EncodingToBinary(Encoding.UTF8);
            var bytes16 = EncodingToBinary(Encoding.Unicode);

            var recon8 = Encoding.UTF8.GetString(bytes16);
            Console.WriteLine("UTF16 to 8: {0}", recon8);

            var recon16 = Encoding.Unicode.GetString(bytes8);
            Console.WriteLine("UTF8 to 16: {0}", recon16);

            ComputeHash();
        }

        private static byte[] EncodingToBinary(Encoding encoding)
        {            
            var text = "ABC";
            var binary = encoding.GetBytes(text);

            foreach (var item in binary)
            {
                Console.WriteLine("{0} : {1}", encoding, item);
            }
            return binary;
        }


        private static void ComputeHash()
        {
            using (var md5 = MD5.Create())
            {
                // Don't use MD5, use SHA256 for 1-way encryption
                var hash = md5.ComputeHash(new byte[10]);
                var hashString = Encoding.UTF8.GetString(hash);

                // Come out as rubbish because it's a random set of characters
                // Same applies for Unicode
                Console.WriteLine("MD5 String: {0}", hashString);

                var hashAgain = Encoding.UTF8.GetBytes(hashString);                
                Console.WriteLine("Encoding UTF8: {0}", hash.SequenceEqual(hashAgain));
                
                // To store bytes, use Base64 to keep it safe
                var hashString64 = Convert.ToBase64String(hash);
                var hashAgain64 = Convert.FromBase64String(hashString64);
                Console.WriteLine("Encoding Base64: {0}", hash.SequenceEqual(hashAgain64));                
            }
        }        
    }
}
