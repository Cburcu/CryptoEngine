using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class MD5Cryptor
    {
        public void MD5CryptorWriteText(string text, Assembly asm)
        {
            Cryptor cryptor = new Cryptor();
            
            var md5 = cryptor.CryptorMethod("MD5Cryptor", text, asm);
            System.IO.File.WriteAllLines(@"C:\Projects\Education\Helpers\MD5Cryptor.txt", md5);

            Console.WriteLine("MD5Cryptor başarılı.");
        }
    }
}
