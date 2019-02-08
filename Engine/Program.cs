using System;
using System.IO;
using System.Reflection;

namespace Engine
{
    class Program
    {
        static void Main(string[] args)
        {
            var asmPath = Path.Combine(@"C:\Projects\Education\HwCryptoEngine\Engine\bin\Debug", "MyEncryptors.dll");
            Assembly asm = Assembly.LoadFile(asmPath);

            string text = File.ReadAllText(@"C:\Projects\Education\Helpers\AnnaKaranina.txt");

            Console.WriteLine("start");

            MC3Cryptor mc3Cryptor = new MC3Cryptor();
            MD5Cryptor md5Cryptor = new MD5Cryptor();
            MW7Cryptor mw7Cryptor = new MW7Cryptor();

            if (args[0] == "-all")
            {
                mc3Cryptor.MC3CryptorWriteText(text, asm);
                md5Cryptor.MD5CryptorWriteText(text, asm);
                mw7Cryptor.MW7CryptorWriteText(text, asm);
            }
            else if (args[0] == "-mc3")
            {
                mc3Cryptor.MC3CryptorWriteText(text, asm);
            }
            else if (args[0] == "-md5")
            {
                md5Cryptor.MD5CryptorWriteText(text, asm);
            }
            else if (args[0] == "-mw7")
            {
                mw7Cryptor.MW7CryptorWriteText(text, asm);
            }
            else
            {
                Console.WriteLine("Select Cryptor");
            }
            

            #region Call Void Method and Property

            //var asmPath = Path.Combine(Environment.CurrentDirectory, "MyEncryptors.dll");
            //Assembly asm = Assembly.LoadFile(asmPath);
            //Object o = asm.CreateInstance("MyEncryptors.MW7Cryptor");
            //if (o != null)
            //{
            //    MethodInfo mi = o.GetType().GetMethod("Mix");
            //    Object[] ob = { "aaa" };

            //    //PropertyInfo name = o.GetType().GetProperty("FilterName");
            //    //name.SetValue(o, "name");
            //    //var nameValue = name.GetValue(o);
            //    //Console.WriteLine(nameValue.ToString());

            //    mi.Invoke(o, ob);

            //}

            #endregion

            Console.ReadLine();
        }
    }
}
