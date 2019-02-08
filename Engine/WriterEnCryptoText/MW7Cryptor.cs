using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class MW7Cryptor
    {
        public void MW7CryptorWriteText(string text, Assembly asm)
        {
            Cryptor cryptor = new Cryptor();
            
            var mw7 = cryptor.CryptorMethod("MW7Cryptor", text, asm);
            System.IO.File.WriteAllLines(@"C:\Projects\Education\Helpers\MW7Cryptor.txt", mw7);

            Console.WriteLine("MW7Cryptor başarılı.");
        }
    }
}
