using System;
using System.IO;
using System.Security.Cryptography;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.Security.Security.Cryptography
{
    public class WindowsDataProtectionCommand : DemoCommand
    {
        public WindowsDataProtectionCommand()
        {
            AddResource("Windows Data Protection", "C# In A Nutshell, Location 34991 of 44380");
        }

        public override string Description
        {
            get { return "Windows Data Protection"; }
        }

        public override void ExecuteDemo()
        {
            ProtectDataDemo();
            FileEncyptDemo();
        }

        private static void FileEncyptDemo()
        {
            // Recovery policy configured for this system contains invalid recovery certificate.
            var fileName = "encrypt.txt";
            File.WriteAllText(fileName, "");
            File.Encrypt(fileName);
            File.AppendAllText(fileName, "More Secret Content!");
        }

        private static void ProtectDataDemo()
        {
            var original = new byte[] {1, 2, 3, 4, 5};
            var scope = DataProtectionScope.CurrentUser;
            var encrypted = ProtectedData.Protect(original, null, scope);
            var unencrypted = ProtectedData.Unprotect(encrypted, null, scope);
            Console.WriteLine();
            Console.WriteLine("Original");
            Array.ForEach(original, b => Console.Write(b));
            Console.WriteLine();
            Console.WriteLine("Encypted");
            Array.ForEach(encrypted, b => Console.Write(b));
            Console.WriteLine();
            Console.WriteLine("Unencrypted");
            Array.ForEach(unencrypted, b => Console.Write(b));
        }
    }
}

