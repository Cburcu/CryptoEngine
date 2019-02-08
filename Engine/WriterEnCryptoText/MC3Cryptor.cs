using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class MC3Cryptor
    {
        public void MC3CryptorWriteText(string text, Assembly asm)
        {
            Cryptor cryptor = new Cryptor();

            var mc3 = cryptor.CryptorMethod("MC3Cryptor", text, asm);
            System.IO.File.WriteAllLines(@"C:\Projects\Education\Helpers\MC3Cryptor.txt", mc3);

            Console.WriteLine("MC3Cryptor başarılı.");
        }
    }
}
