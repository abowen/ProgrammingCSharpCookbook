using System;
using System.IO;
using System.Security.Cryptography;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.DebuggingAndSecurity.Security.Cryptography
{
    public class HashingCommand : DemoCommand
    {
        public HashingCommand()
        {
            AddResource("Hashing", "C# In A Nutshell, Location 35084 of 44380");
        }

        public override string Description
        {
            get { return "Hashing"; }
        }

        public override void ExecuteDemo()
        {
            var fileName = "Hash.txt";

            using (var writer = File.CreateText(fileName))
            {
                writer.WriteLine("HASHING");
            }

            byte[] hash;
            using (var stream = File.OpenRead(fileName))
            {
                hash = MD5.Create().ComputeHash(stream);
            }
            Console.WriteLine("Hash");
            Array.ForEach(hash, b => Console.Write(b));
            Console.WriteLine();
        }


    }
}

