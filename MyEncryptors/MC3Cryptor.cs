using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cryptography;

namespace MyEncryptors
{
    public class MC3Cryptor
        : Cryptor
    {
        public MC3Cryptor()
        {

        }
        public MC3Cryptor(string name)
        {
            base.Name = name;
            base.Key();
        }

        public override double ComplexityRate(string parameter)
        {
            if (parameter.Length < 10)
            {
                double rate = (Convert.ToDouble(parameter.Length) / 10) * 100;
                return rate;
            }
            else
            {
                return 100;
            }
        }

        public override string Description => "MC3 şifrelemesi";

        public override void Mix(string content)
        {
            Console.WriteLine("Mixing");
        }

        public override string[] CryptorMethod(string parameter)
        {
            string[] crypText = parameter.Split(' ');
            return crypText;
        }
    }
}
