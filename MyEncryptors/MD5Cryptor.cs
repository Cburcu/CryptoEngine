using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cryptography;

namespace MyEncryptors
{
    class MD5Cryptor : Cryptor
    {
        public MD5Cryptor()
        {

        }
        public MD5Cryptor(string name)
        {
            base.Name = name;
            base.Key();
        }
        public override double ComplexityRate(string parameter)
        {
            if (parameter.Length < 20)
            {
                var rate = (Convert.ToDouble(parameter.Length) / 20) * 100;
                return rate;
            }
            else
            {
                return 100;
            }
        }
        public override string Description => "MD5 şifrelemesi";
        public override string[] CryptorMethod(string parameter)
        {
            string[] crypText = parameter.Split('b');

            return crypText;
        }

        public override void Mix(string content)
        {
            Console.WriteLine("Mixing");
        }
    }
}
